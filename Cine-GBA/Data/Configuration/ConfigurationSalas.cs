using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cine_GBA.Data.Models;

namespace Cine_GBA.Data.Configuration
{
    class ConfigurationSalas
    {
        public ConfigurationSalas(EntityTypeBuilder<Salas> Builder) 
        {

            Builder.HasKey(s => s.SalaId);
            Builder.Property(s => s.Capacidad).IsRequired();
            Builder.HasMany(s => s.Funciones).WithOne(x => x.Sala).HasForeignKey(s => s.SalaId);

            Builder.HasData(new Salas { SalaId = 1, Capacidad = 5 });
            Builder.HasData(new Salas { SalaId = 2, Capacidad = 15 });
            Builder.HasData(new Salas { SalaId = 3, Capacidad = 35 });

        }



    }
}
