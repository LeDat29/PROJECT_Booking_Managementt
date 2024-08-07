using System;
using System.Collections.Generic;

namespace OnlineOrder.Entities;

public partial class CartDetail
{
    public int CartDetailId { get; set; }

    public int ProductId { get; set; }

    public int? NumberInCart { get; set; }

    public decimal? Price { get; set; }

    public int CartId { get; set; }

    public virtual Cart Cart { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
