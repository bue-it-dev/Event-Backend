using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueLeaveLeaveType
{
    public int Id { get; set; }

    public string LeaveType { get; set; } = null!;

    public string? Description { get; set; }

    public float? MaxDays { get; set; }

    public float? MinDays { get; set; }

    public float? MaxEntitlement { get; set; }

    public float? MinDaysBetweenTwoLeaves { get; set; }

    public float? ApplyAfterMonths { get; set; }

    public sbyte AutoApproved { get; set; }

    public float? RequestedBeforeHours { get; set; }

    public float? TimeToApprovalHours { get; set; }

    public float? MaxCarryOver { get; set; }

    public float? MaxRequestedInDays { get; set; }

    public string LeaveDayType { get; set; } = null!;

    public int? DeductedFrom { get; set; }

    public int? ReturnedTo { get; set; }

    public TimeOnly? SpecificHoursDuration { get; set; }

    public string? SpecificHoursType { get; set; }

    public string? HalfDayMode { get; set; }

    public int? LeaveCarryOverFrom { get; set; }

    public int? MaxRequestedInMonthFrom { get; set; }
}
