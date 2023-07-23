using ProductOrder.Application.Shared;

namespace ProductOrder.Application.OrderProduct;

public class OrderProductDTO : IDTO
{
    public Guid OrderId { get; }

    public OrderProductDTO(Guid orderId)
    {
        OrderId = orderId;
    }
}
