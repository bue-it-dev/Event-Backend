using Event.DTOs;
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

        public EventEntityController(IEventService eventService)
        {
            _eventService = eventService;
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

        [HttpPost("update/{eventId}")]
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
    }
}
