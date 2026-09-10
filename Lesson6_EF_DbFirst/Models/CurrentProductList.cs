using System;
using System.Collections.Generic;

namespace Lesson6_EF_DbFirst.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
