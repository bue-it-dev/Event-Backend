using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class ObjectiveEdit
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int EditedBy { get; set; }

    public string EditedByName { get; set; } = null!;

    public DateTime? EditedAt { get; set; }
}
