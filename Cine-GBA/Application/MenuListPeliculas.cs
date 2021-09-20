using Cine_GBA.Data.Models;
using Cine_GBA.Data.Queries;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Cine_GBA.Application
{
    public class MenuListPeliculas
    {
        public MenuListPeliculas()
        {
            Console.Clear();
        }

        public void ToListResumePeliculas()
        {
            Console.Clear();
            Board();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Peliculas en cartelera");
            Console.WriteLine("");
            ListPeliculas _listPeliculas = new ListPeliculas();
            List<Peliculas> aux = _listPeliculas.ToList();
            foreach (Peliculas objeto in aux)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("\n PeliculaId: {0} " +
                                    "\n Titulo: {1} ",
                                    objeto.PeliculaId, objeto.Titulo);
            }

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

        public void AskMoreInfo()
        {
            try
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("¿Desea ver informacion de alguna pelicula? Indique la opcion numerada no la palabra");
                Console.WriteLine("1- Si");
                Console.WriteLine("2- No");
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("");

                int _eleccion = Convert.ToInt32(Console.ReadLine());

                switch (_eleccion)
                {
                    case 1:
                        MenuListCompletePelicula _menuPeliculas = new MenuListCompletePelicula();
                        _menuPeliculas.SelectPelicula();
                        break;
                    case 2:
                        Console.ReadKey();
                        Menu _menu = new Menu();
                        _menu.MenuInit();
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Opcion incorrecta intente nuevamente");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------------------------------------------------------");
                        Thread.Sleep(2000);
                        ToListResumePeliculas();
                        break;

                }

            }

            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Opcion incorrecta intente nuevamente");
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Thread.Sleep(2000);
                ToListResumePeliculas();
            }
        }

    }
}
