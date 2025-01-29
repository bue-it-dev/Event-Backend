using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueUserRole
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;
}
