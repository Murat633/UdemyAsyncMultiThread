using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class CompanyLike
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int UserId { get; set; }

    public virtual Company Company { get; set; } = null!;
}
