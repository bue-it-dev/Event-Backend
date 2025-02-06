using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class BuildingVenue
{
    public int VenueBuildingId { get; set; }

    public int? EventId { get; set; }

    public int? VenueId { get; set; }

    public virtual EventEntity? Event { get; set; }

    public virtual VenueLookup? Venue { get; set; }
}
