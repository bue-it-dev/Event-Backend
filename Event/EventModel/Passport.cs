using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class Passport
{
    public int PassportId { get; set; }

    public int? EventId { get; set; }

    public string? PassportFile { get; set; }

    public virtual EventEntity? Event { get; set; }
}
