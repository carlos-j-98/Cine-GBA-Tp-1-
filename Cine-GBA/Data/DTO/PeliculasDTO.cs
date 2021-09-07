using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_GBA.Data.DTO
{
    public class PeliculasDTO
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Poster { get; set; }
        public string Sinopsis { get; set; }
        public string Trailer { get; set; }
    }
}
