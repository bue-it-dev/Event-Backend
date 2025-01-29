using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class ObjectiveEditHistory
{
    public int Id { get; set; }

    public int EditId { get; set; }

    public int EmpId { get; set; }

    public string ObjectiveName { get; set; } = null!;

    public string Dimension { get; set; } = null!;

    public string KeyPerformance { get; set; } = null!;

    public string ExpectedResult { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public float Weight { get; set; }

    public float? PercentageAchievement { get; set; }

    public float? GrantedMarks { get; set; }

    public int? Year { get; set; }

    public int Score { get; set; }

    public int Confirm { get; set; }
}
