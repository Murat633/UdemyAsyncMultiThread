using System;
using System.Collections.Generic;

namespace PLINQAPP.Models;

public partial class BalanceOrder
{
    public int Id { get; set; }

    public string MerchandOid { get; set; } = null!;

    public int UserId { get; set; }

    public decimal Balance { get; set; }

    public bool IsSuccess { get; set; }
}
