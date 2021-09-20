using System;

namespace Cine_GBA.Data.Models
{
    public class Tickets
    {
        public Guid TiketId { get; set; }
        public int FuncionId { get; set; }
        public Funciones Funciones { get; set; }
        public string Usuarios { get; set; }
    }
}
