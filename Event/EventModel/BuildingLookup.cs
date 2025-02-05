using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class BuildingLookup
{
    public int BuildingId { get; set; }

    public string Building { get; set; } = null!;

    public virtual ICollection<VenueLookup> VenueLookups { get; set; } = new List<VenueLookup>();
}
