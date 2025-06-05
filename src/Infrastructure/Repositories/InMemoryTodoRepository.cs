namespace SampleDDD.Infrastructure.Repositories;

using SampleDDD.Domain.Entities;
using SampleDDD.Domain.Repositories;

public class InMemoryTodoRepository : ITodoRepository
{
    private readonly List<TodoItem> _items = new();

    public Task AddAsync(TodoItem item)
    {
        _items.Add(item);
        return Task.CompletedTask;
    }

    public Task<IEnumerable<TodoItem>> GetAllAsync() => Task.FromResult(_items.AsEnumerable());

    public Task<TodoItem?> GetByIdAsync(Guid id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        return Task.FromResult(item);
    }
}
