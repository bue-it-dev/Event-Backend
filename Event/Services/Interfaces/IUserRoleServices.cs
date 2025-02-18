using Event.DTOs;

namespace Event.Services.Interfaces
{ 
    public interface IUserRoleServices
    {
     
        Task<EmployeeDTO> GetEmployeeDetails(int empID);
    }
}
