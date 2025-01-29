using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueLeaveEmpLeaveTypeHistoryDocument
{
    public int Id { get; set; }

    public int HistoryId { get; set; }

    public string DocumentTitle { get; set; } = null!;

    public string DocumentFilename { get; set; } = null!;

    public string? DocumentDescription { get; set; }
}
