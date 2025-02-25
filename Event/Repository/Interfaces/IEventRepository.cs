using Event.DTOs;
using Event.EventModel;

namespace Event.Repository.Interfaces
{
    public interface IEventRepository : IGenericRepository<EventEntity>
    {
        //Task Submit(EventEntity eventData);
        Task<string?> SaveFileAsync(IFormFile? file, string folderPath);
        Task SubmitAsync(EventEntity eventData);
        Task<(byte[] FileData, string ContentType)> GetFileAsync(string filePath);
        Task<string?> ReplaceFileAsync(string? existingFilePath, IFormFile? newFile, string folderPath);
        Task<EventEntity> GetWithIncludes(int eventId);
        Task DeleteFileAsync(string filePath);
        Task<List<ApprovalSchema>> GetApprovalDepartmentSchema();
        Task<List<ItcomponentEvent>> GetItComponents();
        Task<IEnumerable<EventEntity>> GetEventsByEmpId(int empId);
        Task SendEventAprovalEmail(int empId, int eventId, int status);
        Task<bool> updateEventApprovals(eventApprovalUpdatesDto eventApprovalUpdatesDto, string userName, int userId);
        Task<IEnumerable<GetEventDTO>> GetEventRequestVCB();
        Task<IEnumerable<GetEventDTO>> GetEventRequestHOD();
        Task<IEnumerable<GetEventDTO>> GetEventRequestOfficeOfThePresident();
        Task<IEnumerable<GetEventDTO>> GetEventRequestSecurityCheck();
        Task<IEnumerable<GetEventDTO>> GetEventRequestPublicAffairs();
        Task<IEnumerable<GetEventDTO>> GetEventRequestIT();
        Task<IEnumerable<GetEventDTO>> GetEventRequestForAcknowledgementsAfterBudget();
        Task<IEnumerable<GetEventDTO>> GetEventRequestTransportation();
        Task<IEnumerable<GetEventDTO>> GetEventRequestAccommodation();
        Task<IEnumerable<GetEventDTO>> GetEventRequest(int userId);
        Task<IEnumerable<GetEventDTO>> GetEventRequestBOM();
        Task<IEnumerable<GetEventDTO>> GetEventRequestEAF();
        Task<IEnumerable<GetEventDTO>> GetEventRequestCOO();
        Task<List<string>> GetEventDetailsById(int eventId);
    }
}
    
