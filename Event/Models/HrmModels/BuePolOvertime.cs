using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolOvertime
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public float WeekendRate { get; set; }

    public float OffHolidayRate { get; set; }

    public float DayInLieuRate { get; set; }

    public int MaxOvertimeRateMonthlyMinutes { get; set; }

    public int MaxOvertimeRateDailyMinutes { get; set; }

    public int MinOvertimeRateDailyMinutes { get; set; }

    public int MinOvertimeRateBeforeWork { get; set; }

    public int MinOvertimeRateAfterWork { get; set; }

    public int DefaultValue { get; set; }

    public float MorningOvertimeRate { get; set; }

    public float EveningOvertimeRate { get; set; }

    public int MaxMorningOvertimeMinutes { get; set; }
}
