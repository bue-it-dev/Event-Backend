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
    }
}
    
