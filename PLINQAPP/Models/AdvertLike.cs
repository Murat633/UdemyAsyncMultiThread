using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class AdvertLike
{
    public int Id { get; set; }

    public int AdvertId { get; set; }

    public int UserId { get; set; }

    public virtual Advert Advert { get; set; } = null!;
}
