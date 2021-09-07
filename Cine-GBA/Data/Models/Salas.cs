using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_GBA.Data.Models
{
    public class Salas
    {
        public int SalaId { get; set; }
        public int Capacidad { get; set; }
        public List<Funciones> Funciones { get; set; }

    }
}
