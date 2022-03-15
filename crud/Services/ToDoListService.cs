using ToDoList.Models;

namespace ToDoList.Services;

public static class ToDoListService
{
    static List<TaskToDo> TasksToDo { get; }
    static int nextId = 3;
    static ToDoListService()
    {
        TasksToDo = new List<TaskToDo>
        {
            new TaskToDo { Id = 1, Title = "Crud in cs", Description = "create a crud project", Done = true},
            new TaskToDo { Id = 2, Title = "Take a coffe", Description = "Make a coffe and take it", Done = false}
        };
    }

    public static List<TaskToDo> GetAll() => TasksToDo;

    public static TaskToDo? Get(int id) => TasksToDo.FirstOrDefault(t => t.Id == id);

    public static void Add(TaskToDo taskToDo)
    {
        taskToDo.Id = nextId++;
        TasksToDo.Add(taskToDo);
    }

    public static void Delete(int id)
    {
        var taskToDo = Get(id);
        if (taskToDo is null)
        {
            return;
        }
        TasksToDo.Remove(taskToDo);
    }

    public static void Update(TaskToDo taskToDo)
    {
        var index = TasksToDo.FindIndex(t => t.Id == taskToDo.Id);
        if (index == -1)
        {
            return;
        }
        TasksToDo[index] = taskToDo;
    }
}