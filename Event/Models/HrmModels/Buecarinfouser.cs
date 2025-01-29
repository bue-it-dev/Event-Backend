using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class Buecarinfouser
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? UserEmail { get; set; }

    public int RoleId { get; set; }

    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual BueEmpEmployee Employee { get; set; } = null!;

    public virtual Buecarinforole Role { get; set; } = null!;
}
