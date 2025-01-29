using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpEmpLang
{
    public int EmpId { get; set; }

    public int LanguageId { get; set; }

    public string Fluency { get; set; } = null!;

    public string? Competency { get; set; }
}
