using System;
using System.Collections.Generic;

namespace OnlineOrder.Entities;

public partial class Cart
{
    public int CartId { get; set; }

    public int AccountId { get; set; }

    public decimal TotalCost { get; set; }

    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();
}
