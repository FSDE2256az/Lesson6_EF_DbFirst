using System;
using System.Collections.Generic;

namespace EF_Loading.Models;

public partial class GetBooksCategoryAuthor
{
    public string Name { get; set; } = null!;

    public int Pages { get; set; }

    public int Quantity { get; set; }

    public int PressYear { get; set; }

    public string CategoryName { get; set; } = null!;

    public string AuthorName { get; set; } = null!;

    public string AuthorsSurname { get; set; } = null!;
}
