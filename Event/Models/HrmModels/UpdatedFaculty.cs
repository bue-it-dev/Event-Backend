using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class UpdatedFaculty
{
    public int Id { get; set; }

    public int EvaluatorId { get; set; }

    public int EvaluateeId { get; set; }

    public string? EvaluatorCode { get; set; }

    public string? EvaluatorName { get; set; }

    public string? EvaluatorDepartment { get; set; }

    public string? EvaluateeCode { get; set; }

    public string? EvaluateeName { get; set; }

    public string? EvaluateeDepartment { get; set; }
}
