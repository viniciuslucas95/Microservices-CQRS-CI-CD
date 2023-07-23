using ProductOrder.Domain.Entities.ProductOrder;

namespace ProductOrder.Application.OrderProduct;

public class OrderProductCommandHandler : IOrderProductCommandHandler
{
    private readonly IOrderProductRepository _repository;

    public OrderProductCommandHandler(IOrderProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<OrderProductDTO> HandleAsync(OrderProductCommand command)
    {
        var entity = ProductOrderEntity.Create(command.ProductId, command.UserId);

        await _repository.OrderAsync(entity);

        return new OrderProductDTO(entity.Id);
    }
}
