using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class MachineApiLog
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public string Method { get; set; } = null!;

    public string Data { get; set; } = null!;

    public string Response { get; set; } = null!;

    public float ResponseTime { get; set; }

    public DateTime CreatedAt { get; set; }
}
