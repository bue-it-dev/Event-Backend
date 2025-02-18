using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Repository.Interfaces;
using Event.DTOs;
using Event.Services.Interfaces;

namespace Event.Services.Implementations
{
    public class UserRoleServices : IUserRoleServices
    {
        private readonly IUserInfoRepository _userinfoRepository;
        private readonly IUnitOfWork _unitofWork;

        public UserRoleServices( IUserInfoRepository userinfoRepository, IUnitOfWork unitofWork )
        {
            this._userinfoRepository = userinfoRepository;
            this._unitofWork = unitofWork;
        }
   
        public async Task<EmployeeDTO> GetEmployeeDetails(int empID)
        {
            var empRecord = await _userinfoRepository.GetEmployeeDetails(empID);
            return empRecord;
        }
     
        }
}

