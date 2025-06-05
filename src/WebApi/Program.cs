using SampleDDD.Application.Services;
using SampleDDD.Infrastructure.Repositories;
using SampleDDD.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ITodoRepository, InMemoryTodoRepository>();
builder.Services.AddScoped<TodoService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("/todos", async (string title, TodoService service) =>
{
    await service.AddAsync(title);
    return Results.Ok();
});

app.MapGet("/todos", async (TodoService service) =>
{
    var items = await service.GetAllAsync();
    return Results.Ok(items);
});

app.MapGet("/todos/{id}", async (Guid id, TodoService service) =>
{
    var item = await service.GetByIdAsync(id);
    return item is null ? Results.NotFound() : Results.Ok(item);
});

app.Run();
