using Microsoft.EntityFrameworkCore;
using BlazorDemo.Models;

namespace BlazorDemo.Data
{
    public class BlazorDemoContext : DbContext
    {
        public BlazorDemoContext(DbContextOptions<BlazorDemoContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorDemo.Models.Categoria> Categoria { get; set; } = default!;
        public DbSet<BlazorDemo.Models.Produto> Produto { get; set; } = default!;
    }
}
