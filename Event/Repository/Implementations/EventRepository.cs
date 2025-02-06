using Event.DTOs;
using Event.EventModel;
using Event.Repository.Interfaces;

namespace Event.Repository.Implementations
{
    public class EventRepository : GenericRepository<EventEntity>, IEventRepository
    {
        private readonly EventContext _dbcontext;
        private readonly IUnitOfWork _unitOfWork;

        public EventRepository(EventContext dbcontext, IUnitOfWork unitOfWork)
            : base(dbcontext, unitOfWork)
        {
            _dbcontext = dbcontext;
            _unitOfWork = unitOfWork;
        }

    }
}
