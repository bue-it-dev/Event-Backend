using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class EmpChangedCategory
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int OldCategory { get; set; }

    public int ChangedBy { get; set; }

    public string ChangedByUsername { get; set; } = null!;

    public DateTime ChangedAt { get; set; }
}
