using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolWorkingDay
{
    public int Id { get; set; }

    public string Day { get; set; } = null!;

    public string State { get; set; } = null!;

    public int DefaultValue { get; set; }
}
