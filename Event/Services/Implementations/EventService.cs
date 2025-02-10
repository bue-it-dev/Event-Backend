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


        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;



        public EventService(IGenericRepository<EventEntity> repository, IEventRepository eventRepository,

            IMapper mapper, IUnitOfWork unitOfWork) : base(repository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }


        public async Task<EventDTO> AddEventData(EventDTO eventData, List<IFormFile> passportData)
        {

            var newEvent = _mapper.Map<EventEntity>(eventData);
            newEvent.CreatedAt = DateTime.Now;

            await _unitOfWork.EventEntity.AddAsync(newEvent);

            if (eventData != null && eventData.HasIt == 1)
            {
                var itcomponentEvents = eventData.ItcomponentEvents
                    .Select(itcomponent => new ItcomponentEvent
                    {
                        EventId = newEvent.EventId,
                        ItcomponentId = itcomponent.ItcomponentId
                    }).ToList();

                _unitOfWork.Set<ItcomponentEvent>().AddRange(itcomponentEvents);
            }

            if (eventData != null && eventData.HasTransportation == 1)
            {
                var transportations = eventData.Transportations
                    .Select(Transportation => new Transportation
                    {
                        EventId = newEvent.EventId,
                        TransportationTypeId = Transportation.TransportationTypeId,
                        StartDate = Transportation.StartDate,
                        EndDate = Transportation.EndDate,
                    }).ToList();

                _unitOfWork.Set<Transportation>().AddRange(transportations);
            }

            if (eventData != null && eventData.HasAccomdation == 1)
            {
                var accommodation = eventData.Accommodations
                    .Select(accommodation => new Accommodation
                    {
                        EventId = newEvent.EventId,
                        RoomTypeId = accommodation.RoomTypeId,
                        StartDate = accommodation.StartDate,
                        EndDate = accommodation.EndDate,
                    }).ToList();

                _unitOfWork.Set<Accommodation>().AddRange(accommodation);
            }



            //if (passportData != null && passportData.Any())
            //{
            //    var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "passports");
            //    if (!Directory.Exists(uploadFolder))
            //    {
            //        Directory.CreateDirectory(uploadFolder);
            //    }

            //    var passports = new List<Passport>();

            //    foreach (var file in passportData) // ✅ Correct: Loop through uploaded files
            //    {
            //        try
            //        {
            //            // Generate a unique file name
            //            var fileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
            //            var filePath = Path.Combine(uploadFolder, fileName);

            //            // Save file to server
            //            using (var stream = new FileStream(filePath, FileMode.Create))
            //            {
            //                await file.CopyToAsync(stream);
            //            }

            //            // Store only the file path in DB
            //            passports.Add(new Passport
            //            {
            //                EventId = newEvent.EventId,
            //                PassportFile = $"/uploads/passports/{fileName}"
            //            });
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine($"Error saving file: {ex.Message}");
            //        }
            //    }

            //    _unitOfWork.Set<Passport>().AddRange(passports);
            //}






            await _unitOfWork.Save();
                return eventData;
            }





        }
        }
    



                    
                
            
