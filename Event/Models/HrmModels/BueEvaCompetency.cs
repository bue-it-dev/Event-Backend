using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEvaCompetency
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int TitleId { get; set; }

    public int Weight { get; set; }
}
