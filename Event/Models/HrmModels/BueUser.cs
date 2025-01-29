using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueUser
{
    public int Id { get; set; }

    public int? EmpId { get; set; }

    public string UserName { get; set; } = null!;

    public string? UserPassword { get; set; }

    public sbyte Status { get; set; }

    public DateTime DateAdded { get; set; }

    public DateTime? DateModified { get; set; }

    public int? ModifiedUserId { get; set; }

    public int? CreatedBy { get; set; }

    public int RoleId { get; set; }

    public string? Authentication { get; set; }
}
