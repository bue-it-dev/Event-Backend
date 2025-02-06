using Event.EventModel;

namespace Event.Repository.Interfaces
{
    public interface IUnitOfWork 
    {

       
            IGenericRepository<ItcomponentEvent> ItcomponentEvent { get; }  
            Task<int> Save();

        
    }
}
