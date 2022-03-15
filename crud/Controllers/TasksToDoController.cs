using ToDoList.Services;
using ToDoList.Models;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers;

[ApiController]
[Route("[controller]")]
public class ToDoListController : ControllerBase
{
    public ToDoListController() { }


    [HttpGet]
    public ActionResult<List<TaskToDo>> GetAll()
    {
        return ToDoListService.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<TaskToDo> Get(int id)
    {
        var taskToDo = ToDoListService.Get(id);

        if (taskToDo == null)
        {
            return NotFound();
        }

        return taskToDo;
    }

    [HttpPost]
    public IActionResult Create(TaskToDo taskToDo)
    {
        ToDoListService.Add(taskToDo);
        return CreatedAtAction(nameof(Create), new { id = taskToDo.Id }, taskToDo);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, TaskToDo taskToDo)
    {
        if (id != taskToDo.Id)
        {
            return BadRequest();
        }

        var existingTaskToDo = ToDoListService.Get(id);
        if (existingTaskToDo == null)
        {
            return NotFound();
        }

        ToDoListService.Update(taskToDo);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var existingTaskToDo = ToDoListService.Get(id);
        if (existingTaskToDo == null)
        {
            return NotFound();
        }

        ToDoListService.Delete(id);

        return NoContent();
    }
}