using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpStatus
{
    public int Id { get; set; }

    public string State { get; set; } = null!;
}
