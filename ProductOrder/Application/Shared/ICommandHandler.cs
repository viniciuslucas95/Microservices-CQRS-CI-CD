namespace ProductOrder.Application.Shared;

public interface ICommandHandler<T, D> where T : ICommand where D : IDTO
{
    public Task<D> HandleAsync(T command);
}
