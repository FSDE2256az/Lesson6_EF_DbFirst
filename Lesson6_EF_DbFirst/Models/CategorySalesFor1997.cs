using System;
using System.Collections.Generic;

namespace Lesson6_EF_DbFirst.Models;

public partial class CategorySalesFor1997
{
    public string CategoryName { get; set; } = null!;

    public decimal? CategorySales { get; set; }
}
