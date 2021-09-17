using Cine_GBA.Data.Models;
using Cine_GBA.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_GBA.Application
{
    public class ShowSalas
    {
        public int CountSalas;
        public void ToListSalas() 
        {

            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Salas disponibles");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            ListSalas _salas = new ListSalas();
            List<Salas> _aux = _salas.ToList();
            CountSalas = _aux.Count;
            foreach(Salas objeto in _aux) 
            {
                
                Console.WriteLine("");
                Console.WriteLine("Identificado de la sala: {0}", objeto.SalaId);
                Console.WriteLine("Capacidad: {0}", objeto.Capacidad);
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");

            }
        }
    }
}
