using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpEmpEducationTmp
{
    public int EmpId2 { get; set; }

    public int EducationId { get; set; }

    public int Year { get; set; }

    public string? GpaScore { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }
}
