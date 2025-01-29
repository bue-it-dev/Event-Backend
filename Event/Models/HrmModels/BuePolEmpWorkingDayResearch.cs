using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolEmpWorkingDayResearch
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string? HalfdayType { get; set; }
}
