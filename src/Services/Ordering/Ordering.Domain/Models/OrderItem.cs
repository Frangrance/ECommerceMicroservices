﻿using Ordering.Domain.Abstractions;

namespace Ordering.Domain.Models;
public class OrderItem : Entity<Guid>
{
    internal OrderItem(OrderId orderId, ProductId productId, int quantity, decimal price) //strong type ids
    {
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        Price = price;
    }

    public Guid OrderId { get; private set; } = default!;
    public Guid ProductId { get; private set; } = default!;
    public int Quantity { get; private set; } = default!;
    public decimal Price { get; private set; } = default!;
}
