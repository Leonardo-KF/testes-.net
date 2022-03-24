using Microsoft.EntityFrameworkCore;
using usuario.Models;

namespace webapi.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var usuario = modelBuilder.Entity<Usuario>();
            usuario.ToTable("users");
            usuario.HasKey(x => x.Id);
            usuario.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x => x.Name).HasColumnName("name").IsRequired();
            usuario.Property(x => x.Password).HasColumnName("password").IsRequired();
        }

        // create a table user in the postgresql database with dotnet


    }
}