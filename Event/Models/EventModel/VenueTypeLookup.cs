using System;
using System.Collections.Generic;

namespace Event.Models.EventModel;

public partial class VenueTypeLookup
{
    public int VenueTypeId { get; set; }

    public string Venue { get; set; } = null!;

    public virtual ICollection<VenueLookup> VenueLookups { get; set; } = new List<VenueLookup>();
}
