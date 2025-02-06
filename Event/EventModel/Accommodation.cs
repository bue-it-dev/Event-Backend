using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class Accommodation
{
    public int AccommodationId { get; set; }

    public int? RoomTypeId { get; set; }

    public int? EventId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual EventEntity? Event { get; set; }

    public virtual RoomLookup? RoomType { get; set; }
}
