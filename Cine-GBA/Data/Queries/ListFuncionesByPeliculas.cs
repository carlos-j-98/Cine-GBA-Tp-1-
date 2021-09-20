using Cine_GBA.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cine_GBA.Data.Queries
{
    public class ListFuncionesByPeliculas
    {
        public List<Funciones> ToList(int id)
        {
            using var context = new ApplicationDbContext();
            var _funciones = (from funciones in context.Funciones
                              where funciones.PeliculaId == id
                              select funciones).ToList();
            return _funciones;
        }
    }
}