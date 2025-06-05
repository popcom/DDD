namespace SampleDDD.Domain.Repositories;

using SampleDDD.Domain.Entities;

public interface ITodoRepository
{
    Task<IEnumerable<TodoItem>> GetAllAsync();
    Task<TodoItem?> GetByIdAsync(Guid id);
    Task AddAsync(TodoItem item);
}
