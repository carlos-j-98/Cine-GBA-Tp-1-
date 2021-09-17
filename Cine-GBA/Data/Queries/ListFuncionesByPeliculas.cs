using Cine_GBA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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