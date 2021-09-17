using Cine_GBA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_GBA.Data.Queries
{
    public class GetPelicula
    {
        public Peliculas GetPeliculaByTitulo(string titulo) 
        {
            using var context = new ApplicationDbContext();

            var _peliculas = (from peliculas in context.Peliculas
                              where peliculas.Titulo == titulo
                              select peliculas).First();
            return _peliculas;
        }
        public Peliculas GetPeliculaById(int id) 
        {
            using var context = new ApplicationDbContext();

            var _peliculas = (from peliculas in context.Peliculas
                              where peliculas.PeliculaId == id
                              select peliculas).First();
            return _peliculas;
        }
    }
}
