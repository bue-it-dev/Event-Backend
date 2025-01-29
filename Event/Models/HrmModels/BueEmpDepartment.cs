using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpDepartment
{
    public int Id { get; set; }

    public string DepartmentName { get; set; } = null!;

    public int? ParentDepartment { get; set; }
}
