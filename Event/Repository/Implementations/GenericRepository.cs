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
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(EventContext eventContext, IUnitOfWork unitOfWork)
        {
            _dbSet = eventContext.Set<T>();
            _unitOfWork = unitOfWork;
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
            try
            {

                await _dbSet.AddAsync(entity);
                await _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _eventContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _unitOfWork.Save();
            }
        }
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _eventContext.AddRangeAsync(entities);
        }



    }
}