using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueAttProcessHistory
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public DateTime ProcessDateTime { get; set; }

    public string? Comment { get; set; }
}
