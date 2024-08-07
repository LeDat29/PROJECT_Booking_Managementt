using System;
using System.Collections.Generic;

namespace OnlineOrder.Entities;

public partial class Order
{
    public int OrderId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public int? AccountId { get; set; }

    public double? TotalMoney { get; set; }

    public int? IsSuccess { get; set; }

    public int? OrderStatus { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
