using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace DbToDoListContext.DbToDoContext;

class ToDoListDb : DbContext
{
    public ToDoListDb(DbContextOptions options) : base(options) { }
    public DbSet<TaskToDo> TasksToDo { get; set; }
}