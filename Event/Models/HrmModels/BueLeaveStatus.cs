using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueLeaveStatus
{
    public int Id { get; set; }

    public short Status { get; set; }

    public string Name { get; set; } = null!;
}
