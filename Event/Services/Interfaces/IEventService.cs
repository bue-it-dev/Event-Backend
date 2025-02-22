using Event.DTOs;
using Event.EventModel;
using Microsoft.AspNetCore.Mvc;

namespace Event.Services.Interfaces
{
    public interface IEventService : IGenericService<EventEntity>
    {
        Task<int> AddEventData(EventDTO eventData);
        Task SubmitEventAsync(int eventId);
        Task<EventGetDTO> GetEventDetailsById(int eventId);
        Task<(byte[] FileData, string ContentType)> GetEventFileAsync(string filePath);
        Task<eventUpdatedDTO> UpdateEvent(int eventId, eventUpdatedDTO eventUpdated);
        Task<int> UpdateFiles(int eventId, List<IFormFile>? passportData, IFormFile? OfficeOfPresedentFile, IFormFile? LedOfTheUniversityOrganizerFile, IFormFile? VisitAgendaFile);
        Task<List<ApprovalSchema>> GetApprovalSchemaDepartments();
        Task<List<ItcomponentEvent>> GetItComponents();
        Task<int> AddFiles(int EventId, List<IFormFile> passportData, IFormFile OfficeOfPresedentFile, IFormFile LedOfTheUniversityOrganizerFile, IFormFile VisitAgendaFile);
        Task<IEnumerable<GetEventDTO>> GetEventByEmpId(int empId);
        Task updateEventApprovals(eventApprovalUpdatesDto eventApprovalUpdatesDto, string userName, int userId);
        Task<IEnumerable<GetEventDTO>> GetEventRequestVCB(string usaerName);

    }
}
