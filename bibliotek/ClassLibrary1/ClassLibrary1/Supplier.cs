using System;
using System.Collections.Generic;

namespace ClassLibrary1;

public partial class Supplier
{
    public int IdSupplier { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
