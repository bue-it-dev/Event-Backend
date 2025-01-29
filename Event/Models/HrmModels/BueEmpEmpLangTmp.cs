using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpEmpLangTmp
{
    public int EmpId2 { get; set; }

    public int LanguageId { get; set; }

    public string Competency { get; set; } = null!;

    public string? Fluency { get; set; }
}
