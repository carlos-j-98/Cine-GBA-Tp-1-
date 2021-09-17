using Cine_GBA.Data.Models;
using Cine_GBA.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Cine_GBA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Funciones> Funciones { get; set; }
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Tickets> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            _ = new ConfigurationFunciones(modelBuilder.Entity<Funciones>());
            _ = new ConfigurationSalas(modelBuilder.Entity<Salas>());
            _ = new ConfigurationPeliculas(modelBuilder.Entity<Peliculas>());
            _ = new ConfigurationTickets(modelBuilder.Entity<Tickets>());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = localhost; Database = Cine-GBA ; Trusted_Connection = True; MultipleActiveResultSets = True");
        }
        
    }
}
