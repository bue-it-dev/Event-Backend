using Event.DTOs;
using Event.EventModel;
using Event.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Event.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleServices _userinfoInterface;

        public UserRoleController(IUserRoleServices userinfoInterface)
        {
            _userinfoInterface = userinfoInterface;
        }

        [HttpGet("GetEmployeeDetails")]
        public async Task<ActionResult<EmployeeDTO>> GetEmployeeDetails()
        {
            var empIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(empIdClaim) || !int.TryParse(empIdClaim, out int empId))
            {
                return Unauthorized("Invalid employee identifier.");
            }

            var user = await _userinfoInterface.GetEmployeeDetails(empId);
            if (user == null)
            {
                return NotFound("Employee not found.");
            }

            return Ok(user);
        }
    }
}
