using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BuePolAttRestriction
{
    public int Id { get; set; }

    public string RestrictionName { get; set; } = null!;

    public TimeOnly MachineCheckInFrom { get; set; }

    public TimeOnly MachineCheckInTo { get; set; }

    public TimeOnly CheckInFrom { get; set; }

    public TimeOnly CheckInTo { get; set; }

    public float AllowedCheckInBeforeMinutes { get; set; }

    public float AllowedCheckInAfterMinutes { get; set; }

    public TimeOnly CheckOutFrom { get; set; }

    public TimeOnly CheckOutTo { get; set; }

    public float AllowedCheckOutBeforeMinutes { get; set; }

    public float AllowedCheckOutAfterMinutes { get; set; }

    public sbyte DefaultValue { get; set; }
}
