namespace ToDoList.Models;

public class TaskToDo
{
    public int Id { get; set; }
    public string? Title { get; set; }

    public string? Description { get; set; }

    public bool Done { get; set; }
}