using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class Advert
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string FromWhere { get; set; } = null!;

    public string FromWhichCity { get; set; } = null!;

    public string ToWhere { get; set; } = null!;

    public string ToWhichWhere { get; set; } = null!;

    public int? Weight { get; set; }

    public decimal? OfferPrice { get; set; }

    public string ProductType { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public string? ServerPath { get; set; }

    public string Phone { get; set; } = null!;

    public int UserId { get; set; }

    public int Views { get; set; }

    public int CategoryId { get; set; }

    public virtual ICollection<AdvertLike> AdvertLikes { get; set; } = new List<AdvertLike>();

    public virtual Category Category { get; set; } = null!;
}
