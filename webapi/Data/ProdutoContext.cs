using Microsoft.EntityFrameworkCore;
using webapi.Models;

// crie o contexto dos produtos e sua conexão com o banco de dados para salva-los
namespace webapi.Data
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var produto = modelBuilder.Entity<Produto>();
            produto.ToTable("produtos");
            produto.HasKey(x => x.Id);
            produto.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            produto.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            produto.Property(x => x.Descricao).HasColumnName("descricao").IsRequired();
            produto.Property(x => x.Preco).HasColumnName("preco").IsRequired();
            produto.Property(x => x.Quantidade).HasColumnName("quantidade").IsRequired();
        }

        // crie a tabela produtos no banco de dados com dotnet
    }
}