using Cine_GBA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cine_GBA.Data.Queries
{
    public class ListFunciones
    {
        public List<Funciones> ToList()
        {
            using var context = new ApplicationDbContext();
            var _listFunciones = (from _funciones in context.Funciones select _funciones).ToList();
            return _listFunciones;
        }
        public List<Funciones> ToListFuncionesByFechaSala(int idSala, DateTime Fecha)
        {
            using (var context = new ApplicationDbContext())
            {
                var funciones = (from x in context.Funciones where x.SalaId == idSala where x.Fecha == Fecha select x).ToList();
                return funciones;
            }
        }
    }
}
