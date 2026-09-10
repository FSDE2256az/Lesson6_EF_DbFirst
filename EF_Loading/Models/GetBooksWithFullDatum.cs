using System;
using System.Collections.Generic;

namespace EF_Loading.Models;

public partial class GetBooksWithFullDatum
{
    public string Name { get; set; } = null!;

    public int Pages { get; set; }

    public int Quantity { get; set; }

    public int YearPress { get; set; }

    public string CategoryName { get; set; } = null!;

    public string AuthorsFullName { get; set; } = null!;

    public string ThemeName { get; set; } = null!;

    public string PressName { get; set; } = null!;
}
