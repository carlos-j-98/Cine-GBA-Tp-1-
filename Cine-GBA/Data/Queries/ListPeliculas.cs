using Cine_GBA.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cine_GBA.Data.Queries
{
    class ListPeliculas
    {
        public List<Peliculas> ToList()
        {
            using var _context = new ApplicationDbContext();
            var Peliculas = (from _peliculas in _context.Peliculas select _peliculas).ToList();
            return Peliculas;
        }
    }
}
