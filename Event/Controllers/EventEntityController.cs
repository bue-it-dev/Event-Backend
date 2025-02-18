using Event.DTOs;
using Event.EventModel;
using Event.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Event.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
  
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
        public async Task<IActionResult> AddEvent([FromForm] EventDTO eventData, [FromForm] List<IFormFile> passportData)
        {
            var result = await _eventService.AddEventData(eventData, passportData);
            return Ok(new GeneralResponse<EventDTO>(true, "Event added successfully", result));
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
        public async Task<IActionResult> UpdateEvent(int eventId, [FromForm] eventUpdatedDTO eventUpdatedData, [FromForm] List<IFormFile> passportData)
        {
            var result = await _eventService.UpdateEvent(eventId, eventUpdatedData,passportData);
            return Ok(new GeneralResponse<eventUpdatedDTO>(true, "Event updated successfully", result));
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
        public async Task<IActionResult> GetVenuse()
        {
            try
            {
                var result = (await _VenueLookup.GetListAsync(x => true)).ToList();

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

    }
}
