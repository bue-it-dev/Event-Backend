using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class ApprovalSchema
{
    public int RowId { get; set; }

    public string? DepName { get; set; }

    public int? FirstApprovalLevelId { get; set; }

    public int? SecondApprovalLevelId { get; set; }

    public int? DepTypeId { get; set; }
}
