namespace ProductOrder.Application.Shared;

public interface IPublishQueue<E> where E : Event
{
    public string Name { get; }

    public void Publish(E data);
}
