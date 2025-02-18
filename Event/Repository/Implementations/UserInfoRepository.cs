using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Reflection.Metadata.Ecma335;
using Event.Repository.Interfaces;
using Event.DTOs;
using Event.Models;

namespace Event.Repository.Implementations
{
    public class UserInfoRepository : IUserInfoRepository
    {
        private readonly HrmDBContext _context;
        public UserInfoRepository( HrmDBContext context)   
        {
            _context = context;
        }

       

        public async Task<EmployeeDTO> GetEmployeeDetails(int userId)
        {
            var data = await (from emp in _context.BueEmpEmployees
                              join dep in _context.BueEmpDepartments
                              on emp.DepartmentId equals dep.Id

                              join job in _context.BueJobsAndTitles
                              on emp.JobId equals job.Id

                              join user in _context.BueUsers
                              on emp.Id equals user.EmpId
                              where userId == emp.Id
                              select new EmployeeDTO
                              {
                                  FullName = emp.Fname +" "+ emp.Mname +" "+ emp.Lname,
                                  code = emp.Code,
                                  Username = user.UserName,
                                  departmentName = dep.DepartmentName,
                                  JobName = job.JobTitle
                              }).FirstOrDefaultAsync();
            return data;
        }
       

    }
}
