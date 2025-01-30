using Event.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Repository.Interfaces
{
    public interface IAuthRepository
    {
        Task<AuthenticateResponsDTO> AuthenticateAsync(string userName, string password);
    }
}
