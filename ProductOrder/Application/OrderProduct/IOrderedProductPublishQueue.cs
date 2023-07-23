using ProductOrder.Application.Shared;

namespace ProductOrder.Application.OrderProduct;

public interface IOrderedProductPublishQueue : IPublishQueue<OrderedProductEvent>
{
}
