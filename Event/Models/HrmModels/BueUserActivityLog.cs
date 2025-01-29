using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueUserActivityLog
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Ip { get; set; }

    public string? Browser { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? Longitude { get; set; }

    public string? Latitude { get; set; }

    public string Session { get; set; } = null!;
}
