using System;
using System.Collections.Generic;

namespace Lesson6_EF_DbFirst.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
