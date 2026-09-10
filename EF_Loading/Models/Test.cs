using System;
using System.Collections.Generic;

namespace EF_Loading.Models;

public partial class Test
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Pages { get; set; }

    public int PressYear { get; set; }

    public int IdThemes { get; set; }

    public int IdCategory { get; set; }

    public int IdAuthor { get; set; }

    public int IdPress { get; set; }

    public string? Comment { get; set; }

    public int Quantity { get; set; }
}
