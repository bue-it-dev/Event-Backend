using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueCreatedEmail
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public int EmpId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Path { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
