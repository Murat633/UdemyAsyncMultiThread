using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int PostCode { get; set; }

    public string City { get; set; } = null!;

    public string Town { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int CategoryId { get; set; }

    public string? Image { get; set; }

    public string? ServerPath { get; set; }

    public int UserId { get; set; }

    public bool IsSuccess { get; set; }

    public bool IsUpdate { get; set; }

    public int Views { get; set; }

    public string FailedMsg { get; set; } = null!;

    public bool IsFailed { get; set; }

    public bool IsInternational { get; set; }

    public string Country { get; set; } = null!;

    public int CountryId { get; set; }

    public int CityId { get; set; }

    public int TownId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<CompanyAd> CompanyAds { get; set; } = new List<CompanyAd>();

    public virtual ICollection<CompanyLike> CompanyLikes { get; set; } = new List<CompanyLike>();

    public virtual ICollection<CompanyRating> CompanyRatings { get; set; } = new List<CompanyRating>();

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
}
