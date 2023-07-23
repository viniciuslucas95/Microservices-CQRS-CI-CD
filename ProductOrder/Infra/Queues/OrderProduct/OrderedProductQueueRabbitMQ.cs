using ProductOrder.Application.OrderProduct;
using ProductOrder.Infra.Queues.Shared;

namespace ProductOrder.Infra.Queues.OrderProduct;

public class OrderedProductQueueRabbitMQ : QueueRabbitMQ<OrderedProductEvent>, IOrderedProductPublishQueue
{
    public OrderedProductQueueRabbitMQ(string host, string username, string password, int port)
        : base("OrderedProduct", host, username, password, port)
    {

    }
}
