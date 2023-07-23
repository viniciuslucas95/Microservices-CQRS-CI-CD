using ProductOrder.Application.Shared;

namespace ProductOrder.Application.OrderProduct;

public interface IOrderProductCommandHandler : ICommandHandler<OrderProductCommand, OrderProductDTO>
{
}
