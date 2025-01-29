using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpReportTo
{
    public int EmpId { get; set; }

    public int EmpReportedToId { get; set; }
}
