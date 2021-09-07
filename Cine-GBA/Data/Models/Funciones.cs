using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_GBA.Data.Models
{
    public class Funciones
    {
        public int FuncionId { get; set; }
        public int PeliculaId { get; set; }
        public int SalaId { get; set; }
        public Peliculas Pelicula { get; set; }
        public Salas Sala { get; set; }
        public List<Tickets> Tickets { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Horario { get; set; }
    }
}
