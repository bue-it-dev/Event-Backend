using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolShift
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public int DefaultValue { get; set; }
}
