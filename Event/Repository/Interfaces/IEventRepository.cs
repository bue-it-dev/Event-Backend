using Event.DTOs;
using Event.EventModel;

namespace Event.Repository.Interfaces
{
    public interface IEventRepository : IGenericRepository<EventEntity>
    {
        //Task Submit(EventEntity eventData);
        Task<string?> SaveFileAsync(IFormFile? file, string folderPath);
        Task SubmitAsync(EventEntity eventData);
    }
}
