using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Order
{
    public int Id { get; private set; }
    public string CustomerName { get; private set; }
    public string ProductName { get; private set; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; private set; }

    public void CalculateTotal()
    {
        var total = Quantity * UnitPrice;
    }
}
