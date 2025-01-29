using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolEmpWorkingDay
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public string Type { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int? WorkingDayId { get; set; }
}
