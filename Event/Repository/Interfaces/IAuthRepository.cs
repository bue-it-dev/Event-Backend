using Event.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BUECarSystem.Interfaces.Repositories
{
    public interface IAuthRepository
    {
        Task<AuthenticateResponsDTO> AuthenticateAsync(string userName, string password);
    }
}
