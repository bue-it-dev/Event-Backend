using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEvaEq
{
    public int Id { get; set; }

    public int TitleId { get; set; }

    public int CompetencyId { get; set; }

    public string Eq { get; set; } = null!;
}
