using System;
using System.Collections.Generic;

namespace Lesson6_EF_DbFirst.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
