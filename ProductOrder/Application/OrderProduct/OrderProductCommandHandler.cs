using ProductOrder.Domain.Entities.ProductOrder;

namespace ProductOrder.Application.OrderProduct;

public class OrderProductCommandHandler : IOrderProductCommandHandler
{
    private readonly IOrderProductRepository _repository;
    private readonly IOrderedProductPublishQueue _queue;

    public OrderProductCommandHandler(IOrderProductRepository repository, IOrderedProductPublishQueue queue)
    {
        _repository = repository;
        _queue = queue;
    }

    public async Task<OrderProductDTO> HandleAsync(OrderProductCommand command)
    {
        var entity = ProductOrderEntity.Create(command.ProductId, command.UserId);

        await _repository.OrderAsync(entity);

        _queue.Publish(new OrderedProductEvent(entity.ProductId, entity.UserId, entity.Id));

        return new OrderProductDTO(entity.Id);
    }
}
