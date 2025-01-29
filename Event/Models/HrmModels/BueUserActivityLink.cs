using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueUserActivityLink
{
    public int Id { get; set; }

    public int ActivityId { get; set; }

    public string Url { get; set; } = null!;

    public DateTime DateTime { get; set; }

    public string? Referer { get; set; }
}
