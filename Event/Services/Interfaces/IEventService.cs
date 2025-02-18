using Event.DTOs;
using Event.EventModel;

namespace Event.Services.Interfaces
{
    public interface IEventService : IGenericService<EventEntity>
    {
        Task<EventDTO> AddEventData(EventDTO eventData, List<IFormFile> passportData);
        Task SubmitEventAsync(int eventId);
        Task<EventGetDTO> GetEventDetailsById(int eventId);
        Task<(byte[] FileData, string ContentType)> GetEventFileAsync(string filePath);
        Task<eventUpdatedDTO> UpdateEvent(int eventId, eventUpdatedDTO eventUpdated, List<IFormFile> passportData);
        Task<List<ApprovalSchema>> GetApprovalSchemaDepartments();
        Task<List<ItcomponentEvent>> GetItComponents();




    }
}
