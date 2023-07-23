using ProductOrder.Application.OrderProduct;
using ProductOrder.Infra.Database.OrderProduct;
using ProductOrder.Infra.Queues.OrderProduct;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IOrderProductCommandHandler, OrderProductCommandHandler>();
builder.Services.AddSingleton<IOrderProductRepository, OrderProductRepositoryMemory>();
builder.Services.AddSingleton<IOrderedProductPublishQueue>(_ => new OrderedProductQueueRabbitMQ("localhost", "guest", "guest", 5672));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
