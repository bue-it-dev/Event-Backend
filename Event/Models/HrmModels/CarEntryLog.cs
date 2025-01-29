using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class CarEntryLog
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? CarId { get; set; }

    public int? CarStatus { get; set; }

    public int? MigrationStatus { get; set; }

    public DateTime? CreatedAt { get; set; }
}
