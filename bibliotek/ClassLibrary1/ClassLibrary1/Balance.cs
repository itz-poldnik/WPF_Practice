using System;
using System.Collections.Generic;

namespace ClassLibrary1;

public partial class Balance
{
    public int IdBalance { get; set; }

    public int? IdProduct { get; set; }

    public int? Quantity { get; set; }

    public virtual Product? IdProductNavigation { get; set; }
}
