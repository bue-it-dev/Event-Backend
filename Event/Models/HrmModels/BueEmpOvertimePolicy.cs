using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpOvertimePolicy
{
    public int EmpId { get; set; }

    public int PolicyId { get; set; }

    public string StartDate { get; set; } = null!;

    public DateOnly EndDate { get; set; }
}
