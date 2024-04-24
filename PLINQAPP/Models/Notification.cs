using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class Notification
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Url { get; set; }

    public int UserId { get; set; }

    public bool IsRead { get; set; }

    public bool IsDeleted { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
