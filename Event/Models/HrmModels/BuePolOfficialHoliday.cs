using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolOfficialHoliday
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string? Description { get; set; }

    public sbyte DefaultValue { get; set; }
}
