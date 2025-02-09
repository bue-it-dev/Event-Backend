using Event.DTOs;
using Event.EventModel;

namespace Event.Repository.Interfaces
{
    public interface IEventRepository : IGenericRepository<EventEntity>
    {
        //Task Submit(EventEntity eventData);

    }
}
