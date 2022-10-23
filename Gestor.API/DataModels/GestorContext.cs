using Microsoft.EntityFrameworkCore;

namespace Gestor.API.DataModels
{
    public class GestorContext : DbContext
    {
        public GestorContext(DbContextOptions<GestorContext> options): base(options)
        {

        }

        public DbSet<Galeria> Galeria { get; set; }

        public DbSet<Concession> Concession { get; set; }

        public DbSet<GalleryType> GalleryType { get; set; }
    }
}
