using System;
using System.Collections.Generic;

namespace Event.Models.HrmModels;

public partial class Buecarinforole
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public int HierarchyLevel { get; set; }

    public virtual ICollection<Buecarinfouser> Buecarinfousers { get; set; } = new List<Buecarinfouser>();
}
