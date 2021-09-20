using System.Collections.Generic;

namespace Cine_GBA.Data.Models
{
    public class Salas
    {
        public int SalaId { get; set; }
        public int Capacidad { get; set; }
        public List<Funciones> Funciones { get; set; }

    }
}
