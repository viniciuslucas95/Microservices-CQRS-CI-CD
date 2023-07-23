using Microsoft.AspNetCore.Mvc;
using ProductOrder.Application.OrderProduct;

namespace ProductOrder.API;

[Route("v1/[controller]")]
[ApiController]
public class ProductOrderController : ControllerBase
{
    private readonly IOrderProductCommandHandler _commandHandler;

    public ProductOrderController(IOrderProductCommandHandler commandHandler)
    {
        _commandHandler = commandHandler;
    }

    [HttpPost]
    public async Task<ActionResult<OrderProductDTO>> OrderProduct([FromBody] OrderProductCommand command)
    {
        var result = await _commandHandler.HandleAsync(command);

        return Ok(result);
    }
}
