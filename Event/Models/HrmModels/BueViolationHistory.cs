using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueViolationHistory
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public DateOnly DateOfViolation { get; set; }

    public string Type { get; set; } = null!;

    public sbyte VioExists { get; set; }
}
