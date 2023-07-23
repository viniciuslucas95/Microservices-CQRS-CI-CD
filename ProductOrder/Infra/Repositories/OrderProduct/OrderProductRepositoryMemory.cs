using ProductOrder.Application.OrderProduct;
using ProductOrder.Domain.Entities.ProductOrder;
using ProductOrder.Infra.Repositories.OrderProduct;

namespace ProductOrder.Infra.Database.OrderProduct;

public class OrderProductRepositoryMemory : IOrderProductRepository
{
    private readonly List<OrderProductModel> _models = new List<OrderProductModel>();

    public Task OrderAsync(ProductOrderEntity entity)
    {
        _models.Add(new OrderProductModel(entity.ProductId, entity.UserId, entity.Status, entity.Id));

        return Task.CompletedTask;
    }
}
