using System;
using System.Collections.Generic;

namespace TaskLinQ.Models;

public partial class ProductInfo
{
    public string FullName { get; set; } = null!;

    public int? Year { get; set; }

    public decimal? Sales { get; set; }
}
