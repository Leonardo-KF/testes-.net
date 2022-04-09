using webapi.Models;
using webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace tarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefasRepository _repository;

        public TarefasController(ITarefasRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(Tarefas tarefa)
        {
            _repository.Add(tarefa);

            return await _repository.SaveChangesAsync() ? Ok("Tarefa cadastrada com sucesso") : StatusCode(500, "Erro ao cadastrar tarefa");
        }

        // adcione a função para atualizar uma tarefa
        [HttpPut]
        public async Task<IActionResult> Put(Tarefas tarefa)
        {
            _repository.Update(tarefa);

            return await _repository.SaveChangesAsync() ? Ok("Tarefa atualizada com sucesso") : StatusCode(500, "Erro ao atualizar tarefa");
        }

        // adcione a função para deletar uma tarefa
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            _repository.Remove(id);

            return await _repository.SaveChangesAsync() ? Ok("Tarefa deletada com sucesso") : StatusCode(500, "Erro ao deletar tarefa");
        }
    }
}