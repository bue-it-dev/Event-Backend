using AutoMapper;
using Event.DTOs;
using Event.EventModel;
using Event.Models;
using Event.Repository.Interfaces;
using Event.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Event.Services.Implementations
{
    public class EventService : GenericService<EventEntity>, IEventService
    {


        private readonly IMapper _mapper;
        public readonly IEventRepository _eventRepository;
        private readonly IUnitOfWork _unitOfWork;



        public EventService(IGenericRepository<EventEntity> repository, IEventRepository eventRepository,

            IMapper mapper, IUnitOfWork unitOfWork) : base(repository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _eventRepository = eventRepository;
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

            var BuildingVenues = eventData.BuildingVenues
                .Select(BuildingVenues => new BuildingVenue
                {
                    EventId = newEvent.EventId,
                    VenueId = BuildingVenues.VenueId,
                }).ToList();

            _unitOfWork.Set<BuildingVenue>().AddRange(BuildingVenues);






            var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

            if (eventData.IsStaffStudents == 1)
            {
                newEvent.LedOfTheUniversityOrganizerFile = await _eventRepository.SaveFileAsync(eventData.LedOfTheUniversityOrganizerFile, uploadFolder);
                if (eventData.IsChairBoardPrisidentVcb == 1)
                {
                    newEvent.OfficeOfPresedentFile = await _eventRepository.SaveFileAsync(eventData.OfficeOfPresedentFile, uploadFolder);
                }
            }

            if (eventData.IsOthers != 0 && eventData.IsOthers != null)
            {
                newEvent.VisitAgendaFile = await _eventRepository.SaveFileAsync(eventData.VisitAgendaFile, uploadFolder);
                if (eventData.IsOthers == 1) //Mean international guests
                {
                    if (passportData != null && passportData.Any())
                    {
                        var uploadFolderPassports = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "passports");
                        if (!Directory.Exists(uploadFolderPassports))
                        {
                            Directory.CreateDirectory(uploadFolderPassports);
                        }

                        var passports = new List<Passport>();

                        foreach (var file in passportData) // ✅ Correct: Loop through uploaded files
                        {
                            try
                            {
                                // Generate a unique file name
                                var fileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
                                var filePath = Path.Combine(uploadFolderPassports, fileName);

                                // Save file to server
                                using (var stream = new FileStream(filePath, FileMode.Create))
                                {
                                    await file.CopyToAsync(stream);
                                }

                                // Store only the file path in DB
                                passports.Add(new Passport
                                {
                                    EventId = newEvent.EventId,
                                    PassportFile = $"/uploads/passports/{fileName}",
                                    CreatedAt = DateTime.Now,
                                });
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error saving file: {ex.Message}");
                            }
                        }

                        _unitOfWork.Set<Passport>().AddRange(passports);
                    }

                }
            }




            await _unitOfWork.Save();
            return eventData;
        }

        public async Task SubmitEventAsync(int eventId)
        {
            var eventData = await _eventRepository.GetAsync(e => e.EventId == eventId);
            if (eventData == null)
            {
                await _eventRepository.SubmitAsync(eventData);
            }
           
        }

      
    }
}







