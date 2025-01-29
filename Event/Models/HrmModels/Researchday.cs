using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class Researchday
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly Start { get; set; }

    public DateOnly End { get; set; }
}
