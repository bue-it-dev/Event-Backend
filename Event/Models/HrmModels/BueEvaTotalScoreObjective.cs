using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEvaTotalScoreObjective
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public float TotalScore { get; set; }

    public int UserId { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly Time { get; set; }
}
