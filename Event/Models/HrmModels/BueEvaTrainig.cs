using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEvaTrainig
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int EmpId { get; set; }

    public int Score { get; set; }

    public string ComName { get; set; } = null!;

    public string TrainigNeeds { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }
}
