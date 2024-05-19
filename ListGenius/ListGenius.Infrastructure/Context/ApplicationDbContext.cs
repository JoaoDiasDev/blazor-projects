// Ignore Spelling: Livros

using ListGenius.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListGenius.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options) : base(options)
    { }
    public DbSet<Livro>? Livros { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(
            typeof(ApplicationDbContext).Assembly);
    }
}
