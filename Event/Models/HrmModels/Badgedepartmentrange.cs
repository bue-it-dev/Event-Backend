using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class Badgedepartmentrange
{
    public int Id { get; set; }

    public int DepbadgeId { get; set; }

    public string DepbadgeName { get; set; } = null!;

    public int RangeFrom { get; set; }

    public int RangeTo { get; set; }

    public int CurrentNumber { get; set; }
}
