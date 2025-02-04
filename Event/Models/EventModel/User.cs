using System;
using System.Collections.Generic;

namespace Event.Models.EventModel;

public partial class User
{
    public int UserId { get; set; }

    public int? EmpId { get; set; }

    public string? UserName { get; set; }

    public string? Email { get; set; }

    public int? UserTypeId { get; set; }

    public byte? Active { get; set; }

    public DateOnly? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public int? DepId { get; set; }

    public byte? IsAcadmic { get; set; }
}
