using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpSalaryFrequency
{
    public int Id { get; set; }

    public string FrequencyName { get; set; } = null!;

    public int DurationInHours { get; set; }
}
