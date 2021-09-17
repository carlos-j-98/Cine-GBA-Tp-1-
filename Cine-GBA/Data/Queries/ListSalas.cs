using Cine_GBA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_GBA.Data.Queries
{
    public class ListSalas
    {
        public List<Salas> ToList() 
        {
            using var context = new ApplicationDbContext();
            var Salas = (from salas in context.Salas select salas).ToList();
            return Salas;
        }
    }
}
