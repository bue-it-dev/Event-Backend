using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.DTOs;

namespace Event.Repository.Interfaces
{
    public interface IUserInfoRepository
    { 
        Task<EmployeeDTO> GetEmployeeDetails(int userId);
    }
}
