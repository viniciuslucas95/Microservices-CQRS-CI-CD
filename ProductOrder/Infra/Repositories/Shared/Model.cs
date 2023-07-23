namespace ProductOrder.Infra.Repositories.Shared;

public abstract class Model
{
    public Guid Id { get; }

    protected Model(Guid id)
    {
        Id = id;
    }
}
