namespace Event.DTOs
{
    public class EmployeeDTO
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public int JobID { get; set; }
        public string JobName { get; set; }
        public int departmentID { get; set; }
        public string departmentName { get; set; }
        public string ParentDepartment { get; set; }
        public string Username { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
