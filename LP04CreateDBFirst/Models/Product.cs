using System;
using System.Collections.Generic;

namespace LP04CreateDBFirst.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int SupplierId { get; set; }

    public int QuantityPerUnit { get; set; }

    public int UnitPrice { get; set; }

    public int UnitsInStock { get; set; }

    public int UnitsOnOrder { get; set; }

    public int RecorderLevel { get; set; }

    public bool Discontinued { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;
}
