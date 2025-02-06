using AutoMapper;
using Event.DTOs;
using Event.EventModel;

namespace Event.Mapping
{
    public class mappingProfile : Profile
    {
        public mappingProfile() 

        {
            CreateMap<EventDTO, EventEntity>().ReverseMap();

            CreateMap<ItcomponentEvent, ItcomponentEventDTO>().ReverseMap();
        }
    }
}
