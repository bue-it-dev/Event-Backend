using System;
using System.Collections.Generic;

namespace Event.Models.EventModel;

public partial class NatureOfEventLookup
{
    public int NatureOfEventId { get; set; }

    public string NatureOfEvent { get; set; } = null!;
}
