using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueAttAttendance
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int? CardNumber { get; set; }

    public DateTime? PunchDate { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly Time { get; set; }

    public string VerifyMode { get; set; } = null!;

    public string PunchInOut { get; set; } = null!;

    public string? PunchInNote { get; set; }

    public string? PunchOutNote { get; set; }

    public int? MachineId { get; set; }

    public int? PunchInOutManualByUser { get; set; }

    public TimeOnly? WorkingHours { get; set; }

    public sbyte Processed { get; set; }

    public TimeOnly? EffectiveWorkingHours { get; set; }

    public TimeOnly? OvertimeNightHours { get; set; }

    public TimeOnly? OvertimeMorningHours { get; set; }

    public sbyte? CalculateAsAbsence { get; set; }
}
