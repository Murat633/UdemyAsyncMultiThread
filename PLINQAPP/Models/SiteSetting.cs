using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class SiteSetting
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Author { get; set; }

    public string? Keywords { get; set; }

    public string? LogoPath { get; set; }

    public string? LogoServerPath { get; set; }

    public bool IsAnnouncement { get; set; }

    public string? AnnouncementType { get; set; }

    public string? AnnouncementTitle { get; set; }

    public string? AnnouncementText { get; set; }
}
