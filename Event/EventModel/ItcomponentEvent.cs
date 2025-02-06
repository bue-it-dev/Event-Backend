using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class ItcomponentEvent
{
    public int ItcomponentEventId { get; set; }

    public int? EventId { get; set; }

    public int? ItcomponentId { get; set; }

    public virtual EventEntity? Event { get; set; }
}
