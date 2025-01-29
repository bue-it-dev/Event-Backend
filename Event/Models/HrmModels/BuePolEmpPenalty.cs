using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolEmpPenalty
{
    public int EmpId { get; set; }

    public int PenaltyId { get; set; }

    public DateOnly Date { get; set; }
}
