using ProductOrder.Domain.Entities.ProductOrder;

namespace ProductOrder.Application.OrderProduct;

public interface IOrderProductRepository
{
    public Task OrderAsync(ProductOrderEntity entity);
}
