using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class RefundedHistory
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int LeaveId { get; set; }

    public float Duration { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public string? Comment { get; set; }

    public int? FinalStatus { get; set; }

    public DateTime? CreatedAt { get; set; }
}
