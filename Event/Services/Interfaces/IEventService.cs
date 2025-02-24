using Event.DTOs;
using Event.EventModel;
using Microsoft.AspNetCore.Mvc;

namespace Event.Services.Interfaces
{
    public interface IEventService : IGenericService<EventEntity>
    {
        Task<int> AddEventData(EventDTO eventData, int userId);
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
        Task<IEnumerable<GetEventDTO>> GetEventRequestVCB();
        Task<bool> updateBudgetOffice(int eventId, updatedBudgetOfficeDTO updatedBudgetOfficeDto, int userId);
        Task<IEnumerable<GetEventDTO>> GetEventRequestHOD( );
        Task<IEnumerable<GetEventDTO>> GetEventRequestOfficeOfThePresident( );
        Task<IEnumerable<GetEventDTO>> GetEventRequestSecurityCheck( );
        Task<IEnumerable<GetEventDTO>> GetEventRequestPublicAffairs( );
        Task<IEnumerable<GetEventDTO>> GetEventRequestIT( );
        Task<IEnumerable<GetEventDTO>> GetEventRequestForAcknowledgementsAfterBudget( );
        Task<IEnumerable<GetEventDTO>> GetEventRequestTransportation( );
        Task<IEnumerable<GetEventDTO>> GetEventRequestAccommodation( );
        Task<IEnumerable<GetEventDTO>> GetEventRequest(int userId);
        Task<IEnumerable<GetEventDTO>> GetEventRequestBOM();
        Task<IEnumerable<GetEventDTO>> GetEventRequestEAF();
        Task<IEnumerable<GetEventDTO>> GetEventRequestCOO();


    }
}
