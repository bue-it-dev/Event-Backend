using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class BueMchMachine
{
    public int Id { get; set; }

    public string MachineName { get; set; } = null!;

    public int? BuildingId { get; set; }

    public string Ip { get; set; } = null!;

    public int Port { get; set; }

    public bool IsUsed { get; set; }

    public sbyte Working { get; set; }

    public int Model { get; set; }
}
