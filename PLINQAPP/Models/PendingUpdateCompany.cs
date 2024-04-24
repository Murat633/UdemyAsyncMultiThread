using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class PendingUpdateCompany
{
    public int Id { get; set; }

    public int UpdatigCompanyId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int PostCode { get; set; }

    public string Phone { get; set; } = null!;

    public int CategoryId { get; set; }

    public string? Image { get; set; }

    public string? ServerPath { get; set; }

    public string? OldServerPath { get; set; }

    public int UserId { get; set; }

    public bool IsSuccess { get; set; }

    public bool IsUpdate { get; set; }

    public int CityId { get; set; }

    public int CountryId { get; set; }

    public int TownId { get; set; }

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}
