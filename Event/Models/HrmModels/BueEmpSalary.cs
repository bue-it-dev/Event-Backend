using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpSalary
{
    public int Id { get; set; }

    public int PayFrequencyId { get; set; }

    public string Currency { get; set; } = null!;
}
