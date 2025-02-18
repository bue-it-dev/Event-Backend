using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class Transportation
{
    public int TransportationId { get; set; }

    public int? TransportationTypeId { get; set; }

    public int? EventId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? Number { get; set; }

    public virtual EventEntity? Event { get; set; }

    public virtual TransportationType? TransportationType { get; set; }
}
