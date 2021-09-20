using System.Linq;

namespace Cine_GBA.Data.Queries
{
    public class GetSalas
    {
        public int GetPlaceSalas(int id)
        {
            using var context = new ApplicationDbContext();
            var _Sala = (from salas in context.Salas where salas.SalaId == id select salas.Capacidad).First();
            return _Sala;
        }
    }
}
