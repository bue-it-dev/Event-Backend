using AutoMapper;
using Event.DTOs;
using Event.EventModel;
using Event.Models;
using Event.Repository.Interfaces;
using Event.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public async Task<int> AddFiles(int EventId, List<IFormFile> passportData, IFormFile OfficeOfPresedentFile, IFormFile LedOfTheUniversityOrganizerFile, IFormFile VisitAgendaFile)
        {
            var eventData = await _eventRepository.GetAsync(e => e.EventId == EventId);
            var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

            if (eventData.IsStaffStudents == 1)
            {
                eventData.LedOfTheUniversityOrganizerFile = await _eventRepository.SaveFileAsync(LedOfTheUniversityOrganizerFile, uploadFolder);
                if (eventData.IsChairBoardPrisidentVcb == 1)
                {
                    eventData.OfficeOfPresedentFile = await _eventRepository.SaveFileAsync(OfficeOfPresedentFile, uploadFolder);
                }
            }

            if (eventData.IsOthers ==1 )
            {
                eventData.VisitAgendaFile = await _eventRepository.SaveFileAsync(VisitAgendaFile, uploadFolder);
                if (eventData.IsVip == 1) //Mean international guests
                {

                    if (passportData != null && passportData.Any())
                    {
                        var uploadFolderPassports = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                        if (!Directory.Exists(uploadFolderPassports))
                        {
                            Directory.CreateDirectory(uploadFolderPassports);
                        }

                        var passports = new List<Passport>();

                        foreach (var file in passportData) 
                        {
                            try
                            {
                                var fileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
                                var filePath = Path.Combine(uploadFolderPassports, fileName);

                                using (var stream = new FileStream(filePath, FileMode.Create))
                                {
                                    await file.CopyToAsync(stream);
                                }

                                passports.Add(new Passport
                                {
                                    EventId = eventData.EventId,
                                    PassportFile = $"/uploads/{fileName}",
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
            return EventId;
        }


        public async Task<int> AddEventData(EventDTO eventData , int userId)
        {

            var newEvent = _mapper.Map<EventEntity>(eventData);
            newEvent.CreatedAt = DateTime.Now;
            newEvent.EmpId = userId;

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





            await _unitOfWork.Save();
            return newEvent.EventId;
        }

        public async Task SubmitEventAsync(int eventId)
        {
            var eventData = await _eventRepository.GetAsync(e => e.EventId == eventId);
            if (eventData != null)
            {
                await _eventRepository.SubmitAsync(eventData);
            }

        }

        public async Task<EventGetDTO> GetEventDetailsById(int eventId)
        {
            var eventData = await _eventRepository.GetAsync(e => e.EventId == eventId);
            List<string> passports = await _eventRepository.GetEventDetailsById(eventId); 

            try
            {
                var eventGetDTO = _mapper.Map<EventGetDTO>(eventData);
                eventGetDTO.LedOfTheUniversityOrganizerFilePath = eventData.LedOfTheUniversityOrganizerFile;
                eventGetDTO.VisitAgendaFilePath = eventData.VisitAgendaFile;
                eventGetDTO.OfficeOfPresedentFilePath = eventData.OfficeOfPresedentFile;
                eventGetDTO.Passports = passports;
                return eventGetDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<(byte[] FileData, string ContentType)> GetEventFileAsync(string filePath)
        {
            return await _eventRepository.GetFileAsync(filePath);
        }

        public async Task<eventUpdatedDTO> UpdateEvent(int eventId, eventUpdatedDTO eventUpdatedData)
        {
            var eventBeforeUpdate = await _eventRepository.GetAsync(e => e.EventId == eventId);
            if (eventBeforeUpdate == null) throw new Exception("Event not found");
            var mapped = _mapper.Map(eventUpdatedData, eventBeforeUpdate);
            eventBeforeUpdate.UpdateAt = DateTime.Now;

            EventEntity eventWithIncludies = await _eventRepository.GetWithIncludes(eventId);
            if (eventWithIncludies != null)
            {
                if (eventWithIncludies != null)
                {
                    _unitOfWork.Set<ItcomponentEvent>().RemoveRange(eventWithIncludies.ItcomponentEvents);
                    if (eventUpdatedData.HasIt == 1)
                    {
                        foreach (var it in eventUpdatedData.ItcomponentEvents)
                        {
                            _unitOfWork.Set<ItcomponentEvent>().Add(new ItcomponentEvent
                            {
                                EventId = eventId,
                                ItcomponentId = it.ItcomponentId
                            });
                        }
                    }

                    _unitOfWork.Set<Transportation>().RemoveRange(eventWithIncludies.Transportations);
                    if (eventUpdatedData.HasTransportation == 1)
                    {
                        foreach (var transportation in eventUpdatedData.Transportations)
                        {
                            _unitOfWork.Set<Transportation>().Add(new Transportation
                            {
                                EventId = eventId,
                                TransportationTypeId = transportation.TransportationTypeId,
                                StartDate = transportation.StartDate,
                                EndDate = transportation.EndDate,
                                Number = transportation.Number

                            });
                        }
                    }

                    _unitOfWork.Set<Accommodation>().RemoveRange(eventWithIncludies.Accommodations);
                    if (eventUpdatedData.HasAccomdation == 1)
                    {
                        foreach (var accommodation in eventUpdatedData.Accommodations)
                        {
                            _unitOfWork.Set<Accommodation>().Add(new Accommodation
                            {
                                EventId = eventId,
                                RoomTypeId = accommodation.RoomTypeId,
                                StartDate = accommodation.StartDate,
                                EndDate = accommodation.EndDate,
                                NumOfRooms = accommodation.NumOfRooms,
                            });
                        }
                    }
                }
            }



            await _unitOfWork.Save();
            return eventUpdatedData;
        }

        public async Task<int> UpdateFiles(int eventId, List<IFormFile>? passportData, IFormFile? OfficeOfPresedentFile, IFormFile? LedOfTheUniversityOrganizerFile, IFormFile? VisitAgendaFile)

        { var eventBeforeUpdate = await _eventRepository.GetAsync(e => e.EventId == eventId);
            var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

            if (eventBeforeUpdate.LedOfTheUniversityOrganizerFile != null)
            {
                await _eventRepository.DeleteFileAsync(eventBeforeUpdate.LedOfTheUniversityOrganizerFile);
                eventBeforeUpdate.LedOfTheUniversityOrganizerFile = null;
            }
            if (eventBeforeUpdate.OfficeOfPresedentFile != null)
            {
                await _eventRepository.DeleteFileAsync(eventBeforeUpdate.OfficeOfPresedentFile);
                eventBeforeUpdate.OfficeOfPresedentFile = null;
            }
            if (eventBeforeUpdate.IsStaffStudents == 1)
            {
                eventBeforeUpdate.LedOfTheUniversityOrganizerFile = await _eventRepository.ReplaceFileAsync(
                    eventBeforeUpdate.LedOfTheUniversityOrganizerFile,
                    LedOfTheUniversityOrganizerFile,
                    uploadFolder);
            }

            

            if (eventBeforeUpdate.IsStaffStudents == 1 && eventBeforeUpdate.IsChairBoardPrisidentVcb == 1)
            {
                eventBeforeUpdate.OfficeOfPresedentFile = await _eventRepository.ReplaceFileAsync(
                    eventBeforeUpdate.OfficeOfPresedentFile,
                    OfficeOfPresedentFile,
                    uploadFolder);
            }

            if (eventBeforeUpdate.VisitAgendaFile != null)
            {
                await _eventRepository.DeleteFileAsync(eventBeforeUpdate.VisitAgendaFile);
                eventBeforeUpdate.VisitAgendaFile = null;
            }
           

            if (eventBeforeUpdate.IsOthers == 1 ) 
            {
                eventBeforeUpdate.VisitAgendaFile = await _eventRepository.ReplaceFileAsync(
                    eventBeforeUpdate.VisitAgendaFile,
                    VisitAgendaFile,
                    uploadFolder);
            }

            var existingPassports = _unitOfWork.Set<Passport>().Where(p => p.EventId == eventBeforeUpdate.EventId).ToList();

            if (existingPassports.Count > 0)
            {
                foreach (var passport in existingPassports)
                {
                    await _eventRepository.DeleteFileAsync(passport.PassportFile);
                }
                _unitOfWork.Set<Passport>().RemoveRange(existingPassports);
            }

            // Add new passport files only if IsOthers == 1 (International guests)
            if (eventBeforeUpdate.IsVip == 1 && passportData != null && passportData.Any())
            {
                var newPassports = new List<Passport>();

                foreach (var file in passportData)
                {
                    try
                    {
                        var fileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
                        var filePath = Path.Combine(uploadFolder, fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        newPassports.Add(new Passport
                        {
                            EventId = eventBeforeUpdate.EventId,
                            PassportFile = $"/uploads/{fileName}",
                            CreatedAt = DateTime.Now,
                        });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving file: {ex.Message}");
                    }
                }

                if (newPassports.Any())
                {
                    _unitOfWork.Set<Passport>().AddRange(newPassports);
                }
            }

            await _unitOfWork.Save();
            return eventBeforeUpdate.EventId;
        }

    


        public async Task<List<ApprovalSchema>> GetApprovalSchemaDepartments()
        {
            var department = await _eventRepository.GetApprovalDepartmentSchema();
            return department;
        }

        public async Task<List<ItcomponentEvent>> GetItComponents()
        {
            var ItComponents = await _eventRepository.GetItComponents();
            return ItComponents;
        }
        public async Task<bool> updateBudgetOffice(int eventId, updatedBudgetOfficeDTO updatedBudgetOfficeDto, int userId)
        {
            try
            {

                var eventRequest = await _eventRepository.GetAsync(e => e.EventId == eventId);
                if (eventRequest != null)
                {
                    eventRequest.BudgetCode = updatedBudgetOfficeDto.BudgetCode;
                    eventRequest.BudgetCostCenter = updatedBudgetOfficeDto.BudgetCostCenter;
                    eventRequest.BudgetlineName = updatedBudgetOfficeDto.budgetlineName;
                    _eventRepository.UpdateAsync(eventRequest);
                }
                _unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<IEnumerable<GetEventDTO>> GetEventByEmpId(int empId)
        {
            var events = await _eventRepository.GetEventsByEmpId(empId);

            var eventDTOs = events.Select(e => new GetEventDTO
            {
                EventId = e.EventId,
                EventTitle = e.EventTitle,
                EventStartDate = e.EventStartDate,
                EventEndDate = e.EventEndDate,
                CreatedAt = e.CreatedAt,
                UpdateAt = e.UpdateAt,
                OrganizerEmail = e.OrganizerEmail,
                OrganizerExtention = e.OrganizerExtention,
                OrganizerMobile = e.OrganizerMobile,
                OrganizerName = e.OrganizerName,
                ApprovingDeptName = e.ApprovingDeptName,
                EmpId = e.EmpId,
                StatusName = e.EventApprovals
                    .OrderByDescending(approval => approval.ApprovalId)
                    .FirstOrDefault()?.Status switch
                {
                    1 => "Approved",
                    0 => "Rejected",
                    _ => "Pending"
                }
            }).ToList();

            return eventDTOs;
        }



        public async Task updateEventApprovals(eventApprovalUpdatesDto eventApprovalUpdatesDto, string userName, int userId)

        {
            var eventapproval = _eventRepository.updateEventApprovals(eventApprovalUpdatesDto, userName, userId);
        }

        public async Task<IEnumerable<GetEventDTO>> GetEventRequestVCB( )
        {
            var result = await _eventRepository.GetEventRequestVCB();
            return result;
        }
        public async Task<IEnumerable<GetEventDTO>> GetEventRequestHOD( )
        {
            var result = await _eventRepository.GetEventRequestHOD();
            return result;
        }
        public async Task<IEnumerable<GetEventDTO>> GetEventRequestOfficeOfThePresident( )
        {
            var result = await _eventRepository.GetEventRequestOfficeOfThePresident();
            return result;
        }
        public async Task<IEnumerable<GetEventDTO>> GetEventRequestSecurityCheck()
        {
            var result = await _eventRepository.GetEventRequestSecurityCheck();
            return result;
        }
        public async Task<IEnumerable<GetEventDTO>> GetEventRequestPublicAffairs( )
        {
            var result = await _eventRepository.GetEventRequestPublicAffairs();
            return result;
        }
        public async Task<IEnumerable<GetEventDTO>> GetEventRequestIT( )
        {
            var result = await _eventRepository.GetEventRequestIT();
            return result;
        }
        public async Task<IEnumerable<GetEventDTO>> GetEventRequestForAcknowledgementsAfterBudget( )
        {
            var result = await _eventRepository.GetEventRequestForAcknowledgementsAfterBudget();
            return result;
        }
        public async Task<IEnumerable<GetEventDTO>> GetEventRequestTransportation()
        {
            var result = await _eventRepository.GetEventRequestTransportation();
            return result;
        }

        public async Task<IEnumerable<GetEventDTO>> GetEventRequestAccommodation()
        {
            var result = await _eventRepository.GetEventRequestAccommodation();
            return result;
        }
        public async Task<IEnumerable<GetEventDTO>> GetEventRequest(int userId)
        {
            var result = await _eventRepository.GetEventRequest(userId);
            return result;
        }

        public async Task<IEnumerable<GetEventDTO>> GetEventRequestBOM( )
        {
            var result = await _eventRepository.GetEventRequestBOM();
            return result;
        }
        public async Task<IEnumerable<GetEventDTO>> GetEventRequestEAF( )
        {
            var result = await _eventRepository.GetEventRequestEAF();
            return result;
        }
        public async Task<IEnumerable<GetEventDTO>> GetEventRequestCOO( )
        {
            var result = await _eventRepository.GetEventRequestCOO();
            return result;
        }

    }
}




