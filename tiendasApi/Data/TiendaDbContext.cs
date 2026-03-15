using Microsoft.EntityFrameworkCore;

namespace tiendasApi.Data
{
    public class TiendaDbContext: DbContext
    {
        public TiendaDbContext(DbContextOptions<TiendaDbContext> options)
             : base(options)
        {
        }

        public DbSet<Entiti.Categoria> Categorias { get; set; }
        public DbSet<Entiti.Productos> Productos { get; set; }
    }
}
