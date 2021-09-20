using Cine_GBA.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cine_GBA.Data.Configuration
{
    class ConfigurationFunciones
    {
        public ConfigurationFunciones(EntityTypeBuilder<Funciones> Builder)
        {
            Builder.HasKey(s => s.FuncionId);
            Builder.Property(s => s.Fecha).IsRequired();
            Builder.Property(s => s.Horario).IsRequired();
            Builder.HasMany(s => s.Tickets)
                .WithOne(x => x.Funciones)
                .HasForeignKey(s => s.FuncionId);
        }
    }
}
