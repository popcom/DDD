namespace SampleDDD.Application.Services;

using SampleDDD.Domain.Entities;
using SampleDDD.Domain.Repositories;

public class TodoService
{
    private readonly ITodoRepository _repository;

    public TodoService(ITodoRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<TodoItem>> GetAllAsync() => _repository.GetAllAsync();

    public Task<TodoItem?> GetByIdAsync(Guid id) => _repository.GetByIdAsync(id);

    public Task AddAsync(string title)
    {
        var item = new TodoItem(title);
        return _repository.AddAsync(item);
    }
}
