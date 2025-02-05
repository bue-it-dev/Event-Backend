using System;
using System.Collections.Generic;

namespace Event.Models
{
    public partial class BueCreatedEmails
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Path { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
