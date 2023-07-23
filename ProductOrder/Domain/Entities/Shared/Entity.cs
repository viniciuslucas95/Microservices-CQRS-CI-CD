namespace ProductOrder.Domain.Entities.Shared;

public abstract class Entity
{
    public Guid Id { get; }

    protected Entity(Guid? id)
    {
        if (id == null) id = Guid.NewGuid();

        Id = (Guid)id;
    }
}
