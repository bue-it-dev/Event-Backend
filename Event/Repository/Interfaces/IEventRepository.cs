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
        Task<IEnumerable<GetEventDTO>> GetEventRequestVCB(string usaerName);
        Task<IEnumerable<GetEventDTO>> GetEventRequestHOD(string usaerName);
        Task<IEnumerable<GetEventDTO>> GetEventRequestOfficeOfThePresident(string usaerName);
        Task<IEnumerable<GetEventDTO>> GetEventRequestSecurityCheck(string usaerName);
    }
}
    
