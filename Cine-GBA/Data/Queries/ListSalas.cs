using Cine_GBA.Data.Models;
using System.Collections.Generic;
using System.Linq;

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
