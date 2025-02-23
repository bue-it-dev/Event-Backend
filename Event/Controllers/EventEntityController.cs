using Event.DTOs;
using Event.EventModel;
using Event.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Event.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes =
    //JwtBearerDefaults.AuthenticationScheme)]
    public class EventEntityController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IGenericService<ItcomponentLookup> _ItcomponentEvent;
        private readonly IGenericService<RoomLookup> _roomLookup;
        private readonly IGenericService<TransportationType> _transportationType;
        private readonly IGenericService<BuildingLookup> _BuildingLookup;
        private readonly IGenericService<VenueLookup> _VenueLookup;




        public EventEntityController(IEventService eventService, IGenericService<ItcomponentLookup> ItcomponentEvent, IGenericService<RoomLookup> roomLookup,
            IGenericService<TransportationType> transportationType, IGenericService<BuildingLookup> BuildingLookup , IGenericService<VenueLookup> VenueLookup)
        {
            _eventService = eventService;
            _ItcomponentEvent = ItcomponentEvent;
            _roomLookup = roomLookup;
            _transportationType = transportationType;
            _BuildingLookup = BuildingLookup;
            _VenueLookup = VenueLookup;

    }

        [HttpPost("add-event")]
        public async Task<IActionResult> AddEvent([FromBody] EventDTO eventData)
        {
            var result = await _eventService.AddEventData(eventData);
            return Ok(new GeneralResponse<int>(true, "Event added successfully", result));
        }

        [HttpPost("add-files")]
        public async Task<IActionResult> AddFiles([FromForm] int EventId, List<IFormFile> passportData, IFormFile OfficeOfPresedentFile, IFormFile LedOfTheUniversityOrganizerFile, IFormFile VisitAgendaFile)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var result = await _eventService.AddFiles(EventId, passportData, OfficeOfPresedentFile, LedOfTheUniversityOrganizerFile, VisitAgendaFile);
            return Ok(new GeneralResponse<int>(true, "Files added successfully", result));
        }

        [HttpPost("submit/{eventId}")]
        public async Task<IActionResult> SubmitEvent(int eventId)
        {
            await _eventService.SubmitEventAsync(eventId);
            return Ok(new GeneralResponse<string>(true, "Event submitted successfully", null));
        }

        [HttpGet("details/{eventId}")]
        public async Task<IActionResult> GetEventDetails(int eventId)
        {
            var eventDetails = await _eventService.GetEventDetailsById(eventId);
            if (eventDetails != null)
            {
                return Ok(new GeneralResponse<EventGetDTO>(true, "Event details retrieved successfully", eventDetails));
            }
            else
            {
                return NotFound(new GeneralResponse<string>(false, "Event not found", null));
            }
        }

        [HttpPut("update/{eventId}")]
        public async Task<IActionResult> UpdateEvent(int eventId, [FromBody] eventUpdatedDTO eventUpdatedData)
        {
            var result = await _eventService.UpdateEvent(eventId, eventUpdatedData);
            return Ok(new GeneralResponse<eventUpdatedDTO>(true, "Event updated successfully", result));
        }
        [HttpPut("update-files/{EventId}")]
        public async Task<IActionResult> Updatefiles(int EventId, List<IFormFile>? passportData, IFormFile? OfficeOfPresedentFile, IFormFile? LedOfTheUniversityOrganizerFile, IFormFile? VisitAgendaFile)
        {
            var result = await _eventService.UpdateFiles(EventId, passportData, OfficeOfPresedentFile, LedOfTheUniversityOrganizerFile, VisitAgendaFile);
            return Ok(new GeneralResponse<int>(true, "Files updated successfully", result));
        }

        [HttpDelete("delete/{eventId}")]
        public async Task<IActionResult> DeleteEvent(int eventId)
        {
            var eventDetails = await _eventService.GetEventDetailsById(eventId);
            if (eventDetails == null)
            {
                return NotFound(new GeneralResponse<string>(false, "Event not found", null));
            }
            await _eventService.DeleteAsync(eventId);
            return Ok(new GeneralResponse<string>(true, "Event deleted successfully", null));
        }

        [HttpGet("get-approval-departments-schema")]
        public async Task<IActionResult> GetApprovalDepartmentSchema()
        {
            try
            {
                var result = await _eventService.GetApprovalSchemaDepartments();
                if (result == null)
                {
                    return NotFound(new GeneralResponse<string>(false, " No departments", null));
                }
                return Ok(new GeneralResponse<List<ApprovalSchema>>(true, "Success", result));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("get-itComponents")]
        public async Task<IActionResult> GetItComponents()
        {
            try
            {
                var result = (await _ItcomponentEvent.GetListAsync(x => true)).ToList(); // ✅ Convert to List

                if (!result.Any()) // ✅ Check for empty list
                {
                    return NotFound(new GeneralResponse<string>(false, "No IT Components found", null));
                }

                return Ok(new GeneralResponse<List<ItcomponentLookup>>(true, "IT Components retrieved successfully", result));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new GeneralResponse<string>(false, "An error occurred", ex.Message)); // ✅ Improved error handling
            }
        }
      
        [HttpGet("get-rooms")]
        public async Task<IActionResult> GetRooms()
        {
            try
            {
                var result = (await _roomLookup.GetListAsync(x => true)).ToList(); 
                if (!result.Any()) 
                {
                    return NotFound(new GeneralResponse<string>(false, "No Rooms found", null));
                }

                return Ok(new GeneralResponse<List<RoomLookup>>(true, "Rooms retrieved successfully", result));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new GeneralResponse<string>(false, "An error occurred", ex.Message));  
            }
        }

        [HttpGet("get-transportationType")]
        public async Task<IActionResult> GetTransportationTypes()
        {
            try
            {
                var result = (await _transportationType.GetListAsync(x => true)).ToList(); 

                if (!result.Any())
                {
                    return NotFound(new GeneralResponse<string>(false, "No transportations found", null));
                }

                return Ok(new GeneralResponse<List<TransportationType>>(true, "Transportation retrieved successfully", result));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new GeneralResponse<string>(false, "An error occurred", ex.Message));
            }
        }
        [HttpGet("get-buildings")]
        public async Task<IActionResult> GetBuildings()
        {
            try
            {
                var result = (await _BuildingLookup.GetListAsync(x => true)).ToList();

                if (!result.Any())
                {
                    return NotFound(new GeneralResponse<string>(false, "No Buildings found", null));
                }

                return Ok(new GeneralResponse<List<BuildingLookup>>(true, "Buildings retrieved successfully", result));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new GeneralResponse<string>(false, "An error occurred", ex.Message));
            }
        }

        [HttpGet("get-venuse")]
        public async Task<IActionResult> GetVenuse(int buildinId)
        {
            try
            {
                var result = (await _VenueLookup.GetListAsync(x => x.BuildingId == buildinId)).ToList();

                if (!result.Any())
                {
                    return NotFound(new GeneralResponse<string>(false, "No Venuse found", null));
                }

                return Ok(new GeneralResponse<List<VenueLookup>>(true, "Venuse retrieved successfully", result));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new GeneralResponse<string>(false, "An error occurred", ex.Message));
            }
        }

        [HttpGet("get-events-by-empId/{empId}")]
        public async Task<IActionResult> GetEventsByEmpId(int empId)
        {
            try
            {
                var result = await _eventService.GetEventByEmpId(empId);
                if (empId == null || result == null)
                {
                    return NotFound(new { message = "No " });
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("update-eventApproval")]
        public async Task<IActionResult> updateBussinessApproval([FromBody] eventApprovalUpdatesDto eventApprovalUpdatesDto)
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _eventService.updateEventApprovals(eventApprovalUpdatesDto, userName, userId);
            return Ok();
          
        }

        [HttpGet("get-eventRequestHOD")]
        public async Task<IActionResult> GetEventRequestHOD()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var result = await _eventService.GetEventRequestHOD(userName);

            if (result == null || !result.Any())
            {
                return NotFound(new GeneralResponse<List<GetEventDTO>>(success: false, message: "No Event requests found", data: null));
            }

            return Ok(new GeneralResponse<IEnumerable<GetEventDTO>>(success: true, message: "Event requests retrieved successfully", data: result));
        }

        [HttpGet("get-eventRequestVCB")]
        public async Task<IActionResult> GetEventRequestVCB()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var result = await _eventService.GetEventRequestVCB(userName);

            if (result == null || !result.Any())
            {
                return NotFound(new GeneralResponse<List<GetEventDTO>>( success: false, message: "No  Events found",data: null));
            }

            return Ok(new GeneralResponse<IEnumerable<GetEventDTO>>(success: true,message: "Event requests retrieved successfully", data: result));
        }



        [HttpPut("update-budget-office-data/{eventId}")]
        public async Task<IActionResult> UpdateBudgetOfficeData(int eventId, updatedBudgetOfficeDTO updatedBudgetOfficeDto)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool updateSucceeded = await _eventService.updateBudgetOffice((int)eventId, updatedBudgetOfficeDto, userId);

            if (updateSucceeded)
            {
                return Ok(" budgetOffice details updated successfully");
            }
            else
            {
                return BadRequest("An error occurred while updating the Budget Office details");
            }

        }

    }
}
    
