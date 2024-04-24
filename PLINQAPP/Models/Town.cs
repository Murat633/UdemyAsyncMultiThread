using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class Town
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CityId { get; set; }

    public virtual City City { get; set; } = null!;
}
