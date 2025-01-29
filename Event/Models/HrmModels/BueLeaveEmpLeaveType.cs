using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueLeaveEmpLeaveType
{
    public int EmpId { get; set; }

    public int LeaveId { get; set; }

    public string StartDate { get; set; } = null!;

    public DateOnly EndDate { get; set; }

    public float Balance { get; set; }

    public int Entitlement { get; set; }

    public int Carryover { get; set; }
}
