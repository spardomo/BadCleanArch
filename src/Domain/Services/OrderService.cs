using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Services;

public static class OrderService
{
    public static List<Order> LastOrders { get; } = new List<Order>();

    public static Order CreateTerribleOrder(string customer, string product, int qty, decimal price)
    {
        var id = new Random().Next(1, 9999999);
        var o = new Order(id, customer, product, qty, price);
        LastOrders.Add(o);
        return o;
    }
}
