using Cine_GBA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
