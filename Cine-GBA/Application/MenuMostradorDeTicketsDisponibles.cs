using Cine_GBA.Data.Models;
using Cine_GBA.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_GBA.Application
{
    public class MenuMostradorDeTicketsDisponibles
    {
        public void InitMenu() 
        {
            GetTickets _getTickets = new GetTickets();
            GetSalas _getSalas = new GetSalas();
            GetPelicula _GetPeliculas = new GetPelicula();
            ListFunciones _listFunciones = new ListFunciones();
            Console.Clear();
            Board();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Funciones disponibles");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            
            foreach (Funciones obj in _listFunciones.ToList())
            {
                Console.WriteLine("");
                Console.WriteLine("| Numero de la funcion: {0}", obj.FuncionId);
                Console.WriteLine("| Fecha: {0}", obj.Fecha);
                Console.WriteLine("| Horario: {0}", obj.Horario);
                Console.WriteLine("| Sala: {0}", obj.SalaId);
                Console.WriteLine("| Pelicula: {0}", _GetPeliculas.GetPeliculaById(obj.PeliculaId).Titulo);
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
            }
            Console.WriteLine("");
            Console.WriteLine("¿De que funcion desea ver la cantidad de tickets disponibles");
            Console.WriteLine("");
            Console.Write("Funcion Nº: ");
            int id = int.Parse(Console.ReadLine());
            int idSala = 0;
            Console.WriteLine("");
            foreach (Funciones x in _listFunciones.ToList()) 
            {
                if (x.FuncionId == id)
                {
                    idSala = x.SalaId;
                }
            }
            Console.WriteLine("Cantidad de tickets disponibles: {0}", 
                              _getSalas.GetPlaceSalas(idSala) - _getTickets.GetTicketsFuncion(id).Count);
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier boton para volver al menu principal");
            Console.ReadKey();
        }



        public static void Board()
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("==================                                                                                    ==================");
            Console.WriteLine("==================               Mostrar Tickets disponibles para una funcion de CINE-GBA             ==================");
            Console.WriteLine("==================                                                                                    ==================");
            Console.WriteLine("========================================================================================================================");
        }
    }
}
