using webapi.Models;
using webapi.Data;
using Microsoft.EntityFrameworkCore;

namespace webapi.Repository
{
    // implemente a interface de tarefas
    public class TarefasRepository : ITarefasRepository
    {
        private readonly TarefaContext _context;

        public TarefasRepository(TarefaContext context)
        {
            _context = context;
        }

        public void Add(Tarefas tarefa)
        {
            _context.Tarefas.Add(tarefa);
        }

        public Tarefas FindById(int id)
        {
            return _context.Tarefas.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Tarefas> FindAll()
        {
            return _context.Tarefas.ToList();
        }

        public void Update(Tarefas tarefa)
        {
            _context.Tarefas.Update(tarefa);
        }

        public void Remove(Tarefas tarefa)
        {
            _context.Tarefas.Remove(tarefa);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}