using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolEmpPermit
{
    public int EmpId { get; set; }

    public int PermitId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public TimeOnly Time { get; set; }
}
