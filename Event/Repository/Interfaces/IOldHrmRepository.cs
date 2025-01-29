using Event.DTOs;
using Event.Models.HrmModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BUECarSystem.Interfaces.Repositories
{
    public interface IOldHrmRepository
    {
        Task<Buecarinfouser> FindEmployeeOneAsync(string code);
        Task<Buecarinfouser> FindOneAsync( string code );
        Task<EmployeeDTO> GetEmployeebyUsername(string username);
    }
}
