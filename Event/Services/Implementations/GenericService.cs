using Event.Repository.Interfaces;
using Event.Services.Interfaces;
using System.Linq.Expressions;

namespace Event.Services.Implementations
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _repository.GetAsync(filter);
        }

        public async Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> filter)
        {
            return await _repository.GetListAsync(filter);
        }

        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
