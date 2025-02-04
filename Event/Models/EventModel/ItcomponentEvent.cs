using System;
using System.Collections.Generic;

namespace Event.Models.EventModel;

public partial class ItcomponentEvent
{
    public int ItcomponentEventId { get; set; }

    public int? EventId { get; set; }

    public int? ItcomponentId { get; set; }

    public virtual Event? Event { get; set; }

    public virtual ItcomponentLookup? Itcomponent { get; set; }
}
