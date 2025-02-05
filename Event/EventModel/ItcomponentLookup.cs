using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class ItcomponentLookup
{
    public int ItcomponentId { get; set; }

    public string Component { get; set; } = null!;

    public virtual ICollection<ItcomponentEvent> ItcomponentEvents { get; set; } = new List<ItcomponentEvent>();
}
