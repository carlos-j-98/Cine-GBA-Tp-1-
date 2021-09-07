using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cine_GBA.Data.DTO;

namespace Cine_GBA.Data.Queries
{
    class ListPeliculas
    {
        public List<PeliculasDTO> ToList() 
        {
            List<PeliculasDTO> aux = new List<PeliculasDTO>();
            using (var _context = new ApplicationDbContext()) 
            {
                var Peliculas = (from _peliculas in _context.Peliculas

                    select new
                    {
                        PeliculaId = _peliculas.PeliculaId,
                        Titulo = _peliculas.Titulo,
                        Poster = _peliculas.Poster,
                        Sinopsis = _peliculas.Sinopsis,
                        Trailer = _peliculas.Trailer
                    }).ToList();
                foreach (var objeto in Peliculas) 
                {
                    PeliculasDTO aux2 = new PeliculasDTO
                    {
                        PeliculaId = objeto.PeliculaId,
                        Titulo = objeto.Titulo,
                        Poster = objeto.Poster,
                        Sinopsis = objeto.Sinopsis,
                        Trailer = objeto.Trailer
                    };
                    aux.Add(aux2);
                }
                Peliculas.OrderBy(x => x.PeliculaId);
                return aux;
            }
        }
    }
}
