using System;
using System.Collections.Generic;

namespace BlazorSchulungV8.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
