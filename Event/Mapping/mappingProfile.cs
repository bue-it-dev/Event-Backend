using AutoMapper;
using Event.DTOs;
using Event.EventModel;

namespace Event.Mapping
{
    public class mappingProfile : Profile
    {
        public mappingProfile() 

        {
            CreateMap<EventDTO, EventEntity>().ForMember(dest => dest.ItcomponentEvents, opt => opt.Ignore())
                .ForMember(dest => dest.Transportations,opt =>opt.Ignore())
                .ForMember(dest => dest.Accommodations, opt => opt.Ignore()).ForMember(dest => dest.BuildingVenues, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ItcomponentEvent, ItcomponentEventDTO>().ReverseMap();
        }
    }
}
