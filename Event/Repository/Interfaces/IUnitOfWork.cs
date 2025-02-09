using Event.EventModel;
using Microsoft.EntityFrameworkCore;

namespace Event.Repository.Interfaces
{
    public interface IUnitOfWork 
    {

       
         IGenericRepository<EventEntity> EventEntity { get; }
        DbSet<T> Set<T>() where T : class;
        Task<int> Save();

        
    }
}
