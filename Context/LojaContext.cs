using SistemaVendas.Models;
using System.Data.Entity;

namespace SistemaVendas.Context
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto>Produto { get; set; } 

    }
}
