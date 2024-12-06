using System;
using System.Collections.Generic;

namespace WpfApp1.Classes;

public partial class Order
{
    public int IdOrder { get; set; }

    public DateOnly? Date { get; set; }

    public int? IdSupplier { get; set; }

    public int? IdProduct { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public virtual Product? IdProductNavigation { get; set; }

    public virtual Supplier? IdSupplierNavigation { get; set; }
}
