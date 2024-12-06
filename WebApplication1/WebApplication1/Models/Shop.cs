using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Shop
{
    public int IdShop { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
}
