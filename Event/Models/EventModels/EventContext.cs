using Microsoft.EntityFrameworkCore;

namespace Event.Models.EventModels
{

    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options) : base(options) { }

    }

}
