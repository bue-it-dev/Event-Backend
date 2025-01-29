using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEvaEmpScore
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int EqId { get; set; }

    public int Score { get; set; }

    public string Evidence { get; set; } = null!;
}
