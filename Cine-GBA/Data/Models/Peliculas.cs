using System.Collections.Generic;

namespace Cine_GBA.Data.Models
{
    public class Peliculas
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Poster { get; set; }
        public string Sinopsis { get; set; }
        public string Trailer { get; set; }
        public List<Funciones> Funciones { get; set; }

    }
}
