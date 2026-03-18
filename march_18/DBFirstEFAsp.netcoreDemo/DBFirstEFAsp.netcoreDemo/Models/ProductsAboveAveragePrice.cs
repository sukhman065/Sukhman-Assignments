using System;
using System.Collections.Generic;

namespace DBFirstEFAsp.netcoreDemo.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
