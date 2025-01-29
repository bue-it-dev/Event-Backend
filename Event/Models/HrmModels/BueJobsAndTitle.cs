using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueJobsAndTitle
{
    public int Id { get; set; }

    public string JobTitle { get; set; } = null!;

    public string? Specification { get; set; }
}
