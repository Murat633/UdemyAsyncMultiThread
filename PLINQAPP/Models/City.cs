using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Town> Towns { get; set; } = new List<Town>();
}
