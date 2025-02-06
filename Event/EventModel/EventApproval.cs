using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class EventApproval
{
    public int ApprovalId { get; set; }

    public int? EventId { get; set; }

    public int? ApprovalLevelId { get; set; }

    public int? EmpId { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual EventApprovalLevelLookup? ApprovalLevel { get; set; }

    public virtual EventEntity? Event { get; set; }
}
