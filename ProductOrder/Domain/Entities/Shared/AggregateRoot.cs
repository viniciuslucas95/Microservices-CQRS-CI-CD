namespace ProductOrder.Domain.Entities.Shared;

public abstract class AggregateRoot : Entity
{
    protected AggregateRoot(Guid? id) : base(id)
    {
    }
}
