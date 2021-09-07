using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cine_GBA.Data.Models;

namespace Cine_GBA.Data.Configuration
{
    class ConfigurationTickets
    {
        public ConfigurationTickets(EntityTypeBuilder<Tickets> Builder) 
        {
            Builder.HasKey(s => new { s.TiketId, s.FuncionId});
            Builder.Property(s => s.Usuarios).IsRequired().HasMaxLength(50);
        }
    }
}
