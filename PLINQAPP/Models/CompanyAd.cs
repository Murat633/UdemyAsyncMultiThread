using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class CompanyAd
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public DateTime EndDate { get; set; }

    public int UserId { get; set; }

    public string? AdsImage { get; set; }

    public virtual Company Company { get; set; } = null!;
}
