using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int PhoneCode { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<PendingUpdateCompany> PendingUpdateCompanies { get; set; } = new List<PendingUpdateCompany>();
}
