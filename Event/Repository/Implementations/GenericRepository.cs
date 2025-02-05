using Event.EventModel;
using Event.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Event.Repository.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly EventContext _eventContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(EventContext eventContext)
        {
            eventContext = _eventContext;
            _dbSet = eventContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.FirstOrDefaultAsync(filter);
        }

        public async Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.Where(filter).ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _eventContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _eventContext.Entry(entity).State = EntityState.Modified;
            await _eventContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _eventContext.SaveChangesAsync();
            }
        }
    }
}