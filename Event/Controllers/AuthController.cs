using Event.DTOs;
using Event.Models;
using Event.Models.HrmModels;
using Event.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Controllers
{
    [Route("/api/auth")]
    [Produces("application/json")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepo;
        private readonly HrmDBContext _context;
        public AuthController(IAuthRepository repo, HrmDBContext context)
        {
            _authRepo = repo;
            _context = context;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> AuthenticateAsync([FromBody] LoginDTO loginResource)
        {
            //nada.rakha
            var user = await _context.BueUsers.Where(col => col.UserName == loginResource.username).FirstOrDefaultAsync();
            if (user != null)
            {
                var userrole = user.RoleId;
                if (userrole != 7 || user.UserName == "ashraf.mohamed") //7 means guest userRole
                {
                    AuthenticateResponsDTO authResp = await _authRepo.AuthenticateAsync(loginResource.username, loginResource.password);
                    if (authResp == null)
                    {
                        return BadRequest(new { message = "Username or password is incorrect" });
                    }
                    return Ok(authResp);
                }
                else
                {
                    return BadRequest("Please login with Staff Account");
                }
            }
            else
            {
                return BadRequest("Login Failed: Please refer to the HR department, as you do not have access to the HRM system.");
            }
        }

    
    }
}
