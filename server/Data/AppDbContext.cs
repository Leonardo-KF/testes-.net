using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
        protected override void OnConfiguring(
            DbContextOptions optionsBuilder
        )
        {
            optionsBuilder.UseSqlite()
        }
    }
}