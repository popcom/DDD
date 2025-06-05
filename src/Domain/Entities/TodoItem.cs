namespace SampleDDD.Domain.Entities;

public class TodoItem
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Title { get; private set; }
    public bool Completed { get; private set; }

    public TodoItem(string title)
    {
        Title = title;
    }

    public void MarkCompleted()
    {
        Completed = true;
    }
}
