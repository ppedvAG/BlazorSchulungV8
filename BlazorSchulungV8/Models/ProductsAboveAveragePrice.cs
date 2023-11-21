using System;
using System.Collections.Generic;

namespace BlazorSchulungV8.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
