using Event.EventModel;
using Event.Repository.Interfaces;

namespace Event.Repository.Implementations
{

    public class ITComponentRepository : GenericRepository<ItcomponentEvent>, IITComponentRepository
    {
        public ITComponentRepository(EventContext eventContext, IUnitOfWork unitOfWork)
            : base(eventContext, unitOfWork) { }
        
    }
}
  

