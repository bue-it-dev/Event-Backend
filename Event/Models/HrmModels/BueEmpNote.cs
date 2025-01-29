using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueEmpNote
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public string Note { get; set; } = null!;

    public int Emp { get; set; }
}
