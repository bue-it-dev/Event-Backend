using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class VenueLookup
{
    public int VenueId { get; set; }

    public int? BuildingId { get; set; }

    public int? VenueTypeId { get; set; }

    public string? VenueName { get; set; }

    public virtual BuildingLookup? Building { get; set; }

    public virtual ICollection<BuildingVenue> BuildingVenues { get; set; } = new List<BuildingVenue>();

    public virtual VenueTypeLookup? VenueType { get; set; }
}
