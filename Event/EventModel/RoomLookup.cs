using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class RoomLookup
{
    public int RoomTypeId { get; set; }

    public string RoomTypeName { get; set; } = null!;
}
