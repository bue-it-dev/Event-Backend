using Event.DTOs;
using Event.EventModel;

namespace Event.Services.Interfaces
{
    public interface IEventService : IGenericService<EventEntity>
    {
        Task<EventDTO> AddEventData(EventDTO eventData, List<IFormFile> passportData);

    }
}
