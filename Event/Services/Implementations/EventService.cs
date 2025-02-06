using AutoMapper;
using Event.DTOs;
using Event.EventModel;
using Event.Models;
using Event.Repository.Interfaces;
using Event.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Event.Services.Implementations
{
    public class EventService : GenericService<EventEntity>, IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly HrmDBContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;



        public EventService(IGenericRepository<EventEntity> repository, IEventRepository eventRepository, HrmDBContext context, IMapper mapper, IUnitOfWork unitOfWork) : base(repository)
        {
            _eventRepository = eventRepository;
            _context = context;
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }


        public async Task<EventDTO> AddEventData(EventDTO eventData)
        {
            var newEvent = _mapper.Map<EventEntity>(eventData);
            newEvent.CreatedAt = DateTime.Now;

            await _eventRepository.AddAsync(newEvent); 

           
            if (eventData != null && eventData.HasIt == 1)
            {
                var itcomponentEvents = new List<ItcomponentEvent>();

                foreach (var itcomponent in eventData.ItcomponentEvents)
                {
                    var it = new ItcomponentEvent
                    {
                        EventId = newEvent.EventId,
                        ItcomponentId = itcomponent.ItcomponentId
                    };
                    itcomponentEvents.Add(it);  
                }

                 await _unitOfWork.ItcomponentEvent.AddRangeAsync(itcomponentEvents);  
            }


            return eventData;

        }



    }
}



                    
                
            
