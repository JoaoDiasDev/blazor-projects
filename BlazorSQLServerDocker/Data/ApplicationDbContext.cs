using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace BlazorSQLServer.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            var dbCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
            if (dbCreator != null)
            {
                // Create Database 
                if (!dbCreator.CanConnect())
                {
                    dbCreator.Create();
                }

                // Create Tables
                if (!dbCreator.HasTables())
                {
                    dbCreator.CreateTables();
                }
            }
        }

        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>().HasData(
                new Contato() { Id = 1, Nome = "Paulo Santos", Email = "paulo@email.com" },
                new Contato() { Id = 2, Nome = "Maria Silveira", Email = "maria@email.com" },
                new Contato() { Id = 3, Nome = "Amanda Lima", Email = "amanda@email.com" });

            base.OnModelCreating(modelBuilder);
        }
    }
}
