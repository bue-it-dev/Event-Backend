using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolPermit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public float PermitHours { get; set; }

    public float PermitDays { get; set; }

    public string PermitType { get; set; } = null!;

    public float PermitRepeatTimeInMonths { get; set; }
}
