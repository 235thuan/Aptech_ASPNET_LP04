using System;
using System.Collections.Generic;

namespace LP04CreateDBFirst.Models;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Age { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Work> Works { get; set; } = new List<Work>();
}
