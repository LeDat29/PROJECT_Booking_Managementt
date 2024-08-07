using System;
using System.Collections.Generic;

namespace OnlineOrder.Entities;

public partial class Account
{
    public int AccountId { get; set; }

    public string Fullname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int Status { get; set; }

    public int RoleId { get; set; }

    public virtual Role Role { get; set; } = null!;
}
