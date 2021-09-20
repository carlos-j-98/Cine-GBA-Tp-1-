using Cine_GBA.Data.Models;
using Cine_GBA.Data.Queries;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Cine_GBA.Application
{
    public class MenuListCompletePelicula
    {
        public MenuListCompletePelicula()
        {
            Console.Clear();
        }

        public void SelectPelicula()
        {
            Console.Clear();
            Board();
            try
            {
                ListPeliculas _listPeliculas = new ListPeliculas();
                _listPeliculas.ToList();
                List<Peliculas> aux = _listPeliculas.ToList();
                foreach (Peliculas objeto in aux)
                {
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("\n PeliculaId: {0} " +
                                      "\n Titulo: {1} ",
                                      objeto.PeliculaId, objeto.Titulo);
                }
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Indique el ID de la pelicula que desea ver ");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("");
                int _eleccion = Convert.ToInt32(Console.ReadLine());
                if (_eleccion >= aux.Count)
                {
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Error en la eleccion de una intente nuevamente");
                    Console.WriteLine("");
                    Console.WriteLine("--------------------------------------------------------------------");
                    Thread.Sleep(2000);
                    SelectPelicula();
                }
                ListCompletePeliculas(_eleccion, aux);

            }

            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Error en la eleccion de una intente nuevamente");
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Thread.Sleep(2000);
                SelectPelicula();
            }
        }

        public void ListCompletePeliculas(int _select, List<Peliculas> _listPeliculas)
        {
            Console.Clear();
            foreach (Peliculas objeto in _listPeliculas)
            {
                if (objeto.PeliculaId == _select)
                {
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("\n PeliculaId: {0} " +
                                      "\n Titulo: {1} " +
                                      "\n Trailer: {2} " +
                                      "\n Sinopsis: {3} " +
                                      "\n Poster: {4}",
                                      objeto.PeliculaId, objeto.Titulo, objeto.Trailer, objeto.Sinopsis,
                                      objeto.Poster);
                }

            }
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para volver al menu principal");
            Console.ReadKey();
            Menu _menu = new Menu();
            _menu.MenuInit();


        }
        public void Board()
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("==================                                                                                    ==================");
            Console.WriteLine("==================                               Cartelera de CINE-GBA                                ==================");
            Console.WriteLine("==================                                                                                    ==================");
            Console.WriteLine("========================================================================================================================");
        }
    }
}
