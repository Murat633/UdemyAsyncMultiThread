using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class User
{
    public int Id { get; set; }

    public string Fullname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int PostCode { get; set; }

    public string Phone { get; set; } = null!;

    public int Gender { get; set; }

    public string? EmailConfirmed { get; set; }

    public string? ImageUrl { get; set; }

    public string? ServerPath { get; set; }

    public string Password { get; set; } = null!;

    public bool IsAdmin { get; set; }

    public decimal Balance { get; set; }
}
