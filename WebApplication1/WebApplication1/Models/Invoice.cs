using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Invoice
{
    public int IdInvoice { get; set; }

    public DateOnly? Date { get; set; }

    public int? IdProduct { get; set; }

    public int? Quantity { get; set; }

    public int? IdShop { get; set; }

    public virtual Product? IdProductNavigation { get; set; }

    public virtual Shop? IdShopNavigation { get; set; }
}
