using Cine_GBA.Data.Models;

namespace Cine_GBA.Data.Command
{
    public class SetFuncion
    {
        public void AddFuncion(Funciones funcion) 
        {
            using var context = new ApplicationDbContext();
            context.Funciones.Add(funcion);
            context.SaveChanges();
        }
    }
}
