using System;
using System.Collections.Generic;

namespace Event.Models.EventModel;

public partial class EventApprovalLevelLookup
{
    public int EventApprovalLevelId { get; set; }

    public int? ApprovalLevel { get; set; }

    public string? ApprovalLevelName { get; set; }

    public virtual ICollection<EventApproval> EventApprovals { get; set; } = new List<EventApproval>();
}
