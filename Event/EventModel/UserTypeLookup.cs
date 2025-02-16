using System;
using System.Collections.Generic;

namespace Event.EventModel;

public partial class UserTypeLookup
{
    public int RowId { get; set; }

    public int? UserTypeId { get; set; }

    public string? UserTypeName { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
