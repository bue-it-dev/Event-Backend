using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueLeaveEmpLeaveTypeHistoryStatus
{
    public int HistoryId { get; set; }

    public int StatusId { get; set; }

    public int UserId { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly Time { get; set; }
}
