using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class TransportationType
{
    public int TransportationTypeId { get; set; }

    public string TransportationType1 { get; set; } = null!;

    public virtual ICollection<Transportation> Transportations { get; set; } = new List<Transportation>();
}
