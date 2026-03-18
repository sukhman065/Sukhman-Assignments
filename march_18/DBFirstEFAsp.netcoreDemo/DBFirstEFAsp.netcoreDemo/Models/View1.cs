using System;
using System.Collections.Generic;

namespace DBFirstEFAsp.netcoreDemo.Models;

public partial class View1
{
    public string CustomerId { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? ContactName { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public string? City { get; set; }
}
