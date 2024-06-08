using System;
using System.Collections.Generic;

namespace DotNet_Practical.Models;

public partial class Cart
{
    public int Id { get; set; }

    public int? Quantity { get; set; }

    public int? ProductId { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Product? Product { get; set; }
}
