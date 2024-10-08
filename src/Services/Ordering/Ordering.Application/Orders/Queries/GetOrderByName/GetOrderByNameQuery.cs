﻿using BuildingBlocks.CQRS;
using Ordering.Application.Dtos;

namespace Ordering.Application.Orders.Queries.GetOrdersByName;

public record GetOrderByNameQuery(string Name)
    : IQuery<GetOrderByNameResult>;

public record GetOrderByNameResult(IEnumerable<OrderDto> Orders);