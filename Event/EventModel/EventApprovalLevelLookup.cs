using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class EventApprovalLevelLookup
{
    public int EventApprovalLevelId { get; set; }

    public int? ApprovalLevel { get; set; }

    public string? ApprovalLevelName { get; set; }
}
