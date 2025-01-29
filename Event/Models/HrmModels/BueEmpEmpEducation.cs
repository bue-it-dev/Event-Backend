using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpEmpEducation
{
    public int EmpId { get; set; }

    public int EducationId { get; set; }

    public int Year { get; set; }

    public string GpaScore { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }
}
