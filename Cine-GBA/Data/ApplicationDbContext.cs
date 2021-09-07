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
            new ConfigurationFunciones(modelBuilder.Entity<Funciones>());
            new ConfigurationSalas(modelBuilder.Entity<Salas>());
            new ConfigurationPeliculas(modelBuilder.Entity<Peliculas>());
            new ConfigurationTickets(modelBuilder.Entity<Tickets>());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = localhost; Database = Cine-GBA ; Trusted_Connection = True; MultipleActiveResultSets = True");
        }
        
    }
}
