using ProductOrder.Application.Shared;

namespace ProductOrder.Application.OrderProduct;

public class OrderProductCommand : ICommand
{
    public Guid UserId { get; }
    public Guid ProductId { get; }

    public OrderProductCommand(Guid userId, Guid productId)
    {
        UserId = userId;
        ProductId = productId;
    }
}
