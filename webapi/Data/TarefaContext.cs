using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Data
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {
        }

        public DbSet<Tarefas> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var tarefas = modelBuilder.Entity<Tarefas>();
            tarefas.ToTable("tarefas");
            tarefas.HasKey(x => x.Id);
            tarefas.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            tarefas.Property(x => x.Titulo).HasColumnName("titulo").IsRequired();
            tarefas.Property(x => x.Prazo).HasColumnName("prazo").IsRequired();
            tarefas.Property(x => x.Concluido).HasColumnName("concluido").IsRequired();
        }

        // crie a tabela tarefas no banco de dados com dotnet
    }
}