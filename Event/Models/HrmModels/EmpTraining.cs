using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class EmpTraining
{
    public uint Id { get; set; }

    public int EmpId { get; set; }

    public sbyte NeedTraining { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
