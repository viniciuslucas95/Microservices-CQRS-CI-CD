using ProductOrder.Domain.Entities.Shared;

namespace ProductOrder.Domain.Entities.ProductOrder;

public class ProductOrderEntity : AggregateRoot
{
    public Guid ProductId { get; }
    public Guid UserId { get; }
    public string Status { get; private set; }

    public ProductOrderEntity(Guid productId, Guid userId, string status, Guid? id = null) : base(id)
    {
        ProductId = productId;
        UserId = userId;
        Status = status;
    }

    public static ProductOrderEntity Create(Guid productId, Guid userId)
    {
        return new ProductOrderEntity(productId, userId, "reserved");
    }
}
