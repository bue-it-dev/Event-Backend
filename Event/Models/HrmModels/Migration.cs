using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class Migration
{
    public string Migration1 { get; set; } = null!;

    public int Batch { get; set; }
}
