using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class RoomLookup
{
    public int RoomTypeId { get; set; }

    public string RoomType { get; set; } = null!;

    public virtual ICollection<Accommodation> Accommodations { get; set; } = new List<Accommodation>();
}
