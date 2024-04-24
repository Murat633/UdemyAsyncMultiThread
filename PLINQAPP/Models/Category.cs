using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Advert> Adverts { get; set; } = new List<Advert>();

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();
}
