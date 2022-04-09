namespace webapi.Models
{
    // crie uma classe publica chamada tarefas que terá os atributos titulo, prazo e concluido
    public class Tarefas
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Prazo { get; set; }
        public bool Concluido { get; set; }
    }
}

