using Event.DTOs;
using Event.Models;
using Event.Models.HrmModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Repository.Implementations
{
    public class OldHrmRepository : IOldHrmRepository
    {
        private readonly HrmDBContext _context;

        public OldHrmRepository(HrmDBContext context)
        {
            _context = context;
        }
        public async Task<Buecarinfouser> FindOneAsync(string code)
        {
            var queryResult = await (from emp in _context.BueEmpEmployees
                                     join user in _context.BueUsers
                                     on emp.Id equals user.EmpId
                                     where emp.Code == code
                                     select new Buecarinfouser
                                     {
                                         FirstName = emp.Fname,
                                         MiddleName = emp.Mname,
                                         LastName = emp.Lname,
                                         UserName = user.UserName,
                                         EmployeeId = emp.Id,
                                         Code = emp.Code,

                                     }).FirstOrDefaultAsync();
            return queryResult;
        }

        public async Task<Buecarinfouser> FindEmployeeOneAsync(string code)
        {
            var queryResult = await (from emp in _context.BueEmpEmployees
                                     where emp.Code == code
                                     select new Buecarinfouser
                                     {
                                         FirstName = emp.Fname,
                                         MiddleName = emp.Mname,
                                         LastName = emp.Lname,
                                         EmployeeId = emp.Id,
                                         Code = emp.Code,

                                     }).FirstOrDefaultAsync();
            return queryResult;
        }

        public async Task<EmployeeDTO> GetEmployeebyUsername(string username)
        {
            try
            {


                var employee = await (from U in _context.BueUsers
                                      join Employee in _context.BueEmpEmployees
                                      on U.EmpId equals Employee.Id into BUEUserGroup
                                      from E in BUEUserGroup.DefaultIfEmpty()

                                      join D in _context.BueEmpDepartments
                                      on E.DepartmentId equals D.Id

                                      join T in _context.BueJobsAndTitles
                                      on E.JobId equals T.Id

                                      //join C in _context.Buecarinfousers
                                      //on E.Id equals C.EmployeeId into EmployeeUser
                                      //from C in EmployeeUser.DefaultIfEmpty()

                                      //join R in _context.Buecarinforoles
                                      //on C.RoleId equals R.RoleId into UserRole
                                      //from R in UserRole.DefaultIfEmpty()

                                      where U.UserName == username
                                      select new EmployeeDTO
                                      {
                                          id = E.Id,
                                          Username = U.UserName,
                                          FullName = E.Fname + " " + E.Mname + " " + E.Lname,
                                          JobID = T.Id,
                                          JobName = T.JobTitle,
                                          departmentID = D.Id,
                                          departmentName = D.DepartmentName,
                                          //RoleID = R.RoleId,
                                          //RoleName = R == null ? "User" : R.RoleName
                                      }).FirstOrDefaultAsync();
                if (employee != null)
                    return employee;
                else
                    return null;
            }
            catch (Exception e)
            { throw e; }
        }
    }
}
