using ProductOrder.Infra.Repositories.Shared;

namespace ProductOrder.Infra.Repositories.OrderProduct;

public class OrderProductModel : Model
{
    public Guid ProductId { get; }
    public Guid UserId { get; }
    public string Status { get; }

    public OrderProductModel(Guid productId, Guid userId, string status, Guid id) : base(id)
    {
        ProductId = productId;
        UserId = userId;
        Status = status;
    }
}
