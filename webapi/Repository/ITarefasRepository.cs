using webapi.Models;

namespace webapi.Repository
{
    // crie a interface de tareafas da aplicação
    public interface ITarefasRepository
    {
        // crie os métodos de acesso a dados
        void Add(Tarefas tarefa);
        Tarefas FindById(int id);
        IEnumerable<Tarefas> FindAll();
        void Update(Tarefas tarefa);
        void Remove(Tarefas tarefa);
        Task<bool> SaveChangesAsync();
    }
}