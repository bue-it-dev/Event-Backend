using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class NewLeaveApproval
{
    public int LeaveId { get; set; }

    public int DepartmentId { get; set; }

    public string ApprovedByEmp { get; set; } = null!;

    public int? ApprovedByEmpLeavesApprovedBy { get; set; }

    public int Priority { get; set; }

    public float? ApprovedByEmpIfExceed { get; set; }
}
