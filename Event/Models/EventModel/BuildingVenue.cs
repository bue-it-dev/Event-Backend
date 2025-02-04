using System;
using System.Collections.Generic;

namespace Event.Models.EventModel;

public partial class BuildingVenue
{
    public int VenueBuildingId { get; set; }

    public int? EventId { get; set; }

    public int? VenueId { get; set; }

    public virtual Event? Event { get; set; }

    public virtual VenueLookup? Venue { get; set; }
}
