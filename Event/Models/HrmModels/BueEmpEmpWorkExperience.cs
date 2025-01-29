using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpEmpWorkExperience
{
    public int EmpId { get; set; }

    public int WorkExperienceId { get; set; }

    public string DateFrom { get; set; } = null!;

    public DateOnly DateTo { get; set; }

    public float? Salary { get; set; }
}
