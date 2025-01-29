using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpEducation
{
    public int Id { get; set; }

    public int Level { get; set; }

    public string University { get; set; } = null!;

    public string? MajorSpecification { get; set; }

    public string? MinorSpecification { get; set; }
}
