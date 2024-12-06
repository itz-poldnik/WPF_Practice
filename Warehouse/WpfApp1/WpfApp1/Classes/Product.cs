using System;
using System.Collections.Generic;

namespace WpfApp1.Classes;

public partial class Product
{
    public int IdProduct { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Unit { get; set; }

    public int? IdSupplier { get; set; }

    public virtual Supplier? IdSupplierNavigation { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
