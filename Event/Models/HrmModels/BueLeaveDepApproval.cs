using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueLeaveDepApproval
{
    public int LeaveId { get; set; }

    public int DepartmentId { get; set; }

    public int ApprovedByEmp { get; set; }

    public int? ApprovedByEmpLeavesApprovedBy { get; set; }

    public int Priority { get; set; }

    public float? ApprovedByEmpIfExceed { get; set; }
}
