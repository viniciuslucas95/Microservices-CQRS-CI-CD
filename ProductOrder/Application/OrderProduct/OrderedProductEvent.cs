using ProductOrder.Application.Shared;

namespace ProductOrder.Application.OrderProduct;

public class OrderedProductEvent : Event
{
    public Guid ProductId { get; }
    public Guid UserId { get; }
    public Guid OrderId { get; }

    public OrderedProductEvent(Guid productId, Guid userId, Guid orderId)
    {
        ProductId = productId;
        UserId = userId;
        OrderId = orderId;
    }
}
