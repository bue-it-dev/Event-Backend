using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueResource
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string? Route { get; set; }

    public int? ParentResource { get; set; }

    public sbyte IsMenu { get; set; }
}
