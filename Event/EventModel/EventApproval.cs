using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class EventApproval
{
    public int ApprovalId { get; set; }

    public int? EventId { get; set; }

    public int? UserTypeId { get; set; }

    public int? EmpId { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? IsApprove { get; set; }

    public virtual EventEntity? Event { get; set; }

    public virtual EventApprovalLevelLookup? UserType { get; set; }
}
