using System;
using System.Collections.Generic;

namespace LP04CreateDBFirst.Models;

public partial class Work
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
