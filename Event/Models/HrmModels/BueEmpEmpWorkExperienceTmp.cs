using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpEmpWorkExperienceTmp
{
    public int EmpId2 { get; set; }

    public int WorkExperienceId { get; set; }

    public string DateFrom { get; set; } = null!;

    public DateOnly DateTo { get; set; }

    public float? Salary { get; set; }

    public string? Position { get; set; }
}
