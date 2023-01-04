using ListApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ListApp.Context
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
