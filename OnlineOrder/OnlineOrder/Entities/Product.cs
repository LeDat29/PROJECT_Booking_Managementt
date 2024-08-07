using System;
using System.Collections.Generic;

namespace OnlineOrder.Entities;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public double? Price { get; set; }

    public int? ProductQuantity { get; set; }

    public string? ProductImage { get; set; }

    public int ProductStatus { get; set; }

    public int CategoryId { get; set; }

    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
