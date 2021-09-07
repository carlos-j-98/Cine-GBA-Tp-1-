using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
