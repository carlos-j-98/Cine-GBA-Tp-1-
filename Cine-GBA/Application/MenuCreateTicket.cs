using Cine_GBA.Data.Command;
using Cine_GBA.Data.Models;
using Cine_GBA.Data.Queries;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Cine_GBA.Application
{
    public class MenuCreateTicket
    {
        public void DisplayFunciones()
        {
            Console.Clear();
            Board();
            ListFunciones _GetFunciones = new ListFunciones();
            List<Funciones> _ListFunciones = _GetFunciones.ToList();
            GetPelicula getPelicula = new GetPelicula();
            GetSalas _getSalas = new GetSalas();
            GetTickets _getTickets = new GetTickets();
            int idSala = 0;

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Informacion de la funcion");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");

            if (_ListFunciones.Count > 0)
            {
                foreach (Funciones obj in _ListFunciones)
                {
                    Console.WriteLine("| Numero de funcion: {0}", obj.FuncionId);
                    Console.WriteLine("| Fecha: {0}", obj.Fecha.ToShortDateString());
                    Console.WriteLine("| Horario: {0}", obj.Horario);
                    Console.WriteLine("| Sala: {0}", obj.SalaId);
                    Console.WriteLine("| Pelicula: {0}", getPelicula.GetPeliculaById(obj.PeliculaId).Titulo);
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("");
                }
            }
            else
            {
                throw new Exception();
            }
            Console.Write("Indique el numero de la funcion que desea crear el ticket: ");
            int eleccionFuncion = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Cual es su nombre: ");
            string usuario = Console.ReadLine();
            Console.WriteLine("");
            foreach (Funciones x in _ListFunciones)
            {
                if (x.FuncionId == eleccionFuncion)
                {
                    idSala = x.SalaId;
                }
            }
            if (_getSalas.GetPlaceSalas(idSala) == _getTickets.GetTicketsFuncion(eleccionFuncion).Count)
            {
                Console.WriteLine("La funcion que usted eligio esta completa, sera reenviado al menu principal");
                Console.WriteLine("");
                Thread.Sleep(4000);
            }
            else
            {
                Tickets tickets = new Tickets()
                {
                    TiketId = Guid.NewGuid(),
                    FuncionId = eleccionFuncion,
                    Usuarios = usuario
                };
                NewTicket newTicket = new NewTicket();
                newTicket.GenTicket(tickets);
                Console.WriteLine("El ticket a sido creado");
                Console.WriteLine("");
                Console.WriteLine("Regresando al menu principal");
                Thread.Sleep(4000);
            }


        }
        public static void Board()
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("==================                                                                                    ==================");
            Console.WriteLine("==================                          Creador de Tickets de CINE-GBA                            ==================");
            Console.WriteLine("==================                                                                                    ==================");
            Console.WriteLine("========================================================================================================================");
        }
    }
}
