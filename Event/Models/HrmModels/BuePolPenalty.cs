using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolPenalty
{
    public int Id { get; set; }

    public string Penalty { get; set; } = null!;

    public string DayHour { get; set; } = null!;

    public float DayHourRate { get; set; }
}
