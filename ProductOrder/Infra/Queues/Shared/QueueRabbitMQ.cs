using ProductOrder.Application.Shared;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace ProductOrder.Infra.Queues.Shared;

public abstract class QueueRabbitMQ<E> : IPublishQueue<E> where E : Event
{
    public string Name { get; }

    private readonly ConnectionFactory _connectionFactory;

    public QueueRabbitMQ(string name, string host, string username, string password, int port)
    {
        Name = name;

        _connectionFactory = new ConnectionFactory
        {
            HostName = host,
            UserName = username,
            Password = password,
            Port = port
        };
    }

    public void Publish(E data)
    {
        ExecWithChannel(channel =>
        {
            channel.QueueDeclare(Name, true, false, false);

            string stringfiedData = JsonSerializer.Serialize(data);
            byte[] body = Encoding.UTF8.GetBytes(stringfiedData);

            channel.BasicPublish(exchange: "", routingKey: Name, body: body);
        });

    }

    private void ExecWithChannel(Action<IModel> withChannel)
    {
        using var connection = _connectionFactory.CreateConnection();
        using var channel = connection.CreateModel();

        withChannel(channel);
    }
}
