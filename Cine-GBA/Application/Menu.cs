using System;
using System.Threading;

namespace Cine_GBA.Application
{
    public class Menu
    {
        public Menu()
        {
            Console.Clear();
        }
        public void MenuInit()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Welcome();
            ListOptions();
            Console.WriteLine("");
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            try
            {
                int _eleccion = Convert.ToInt32(Console.ReadLine());
                switch (_eleccion)
                {
                    case 1:
                        MenuListPeliculas _menuPeliculas = new MenuListPeliculas();
                        _menuPeliculas.ToListResumePeliculas();
                        _menuPeliculas.AskMoreInfo();
                        break;
                    case 2:
                        MenuListFuncionByPelicula _menuFuncionesPelis = new MenuListFuncionByPelicula();
                        _menuFuncionesPelis.SelectFuncion();
                        break;
                    case 3:
                        NewFuncion _funcion = new NewFuncion();
                        _funcion.MakeFuncion();
                        break;
                    case 4:
                        MenuCreateTicket menuCreateTicket = new MenuCreateTicket();
                        menuCreateTicket.DisplayFunciones();
                        break;
                    case 5:
                        MenuMostradorDeTicketsDisponibles menuMostradorDeTicketsDisponibles = new MenuMostradorDeTicketsDisponibles();
                        menuMostradorDeTicketsDisponibles.InitMenu();
                        break;
                    case 6:
                        System.Environment.Exit(1);
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Esa opcion no existe. Intente nuevamente");
                Thread.Sleep(2000);
                MenuInit();
            }
            MenuInit();
        }
        public void ListOptions()
        {

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1- Lista de peliculas");
            Console.WriteLine("2- Ver funciones de una pelicula");
            Console.WriteLine("3- Registrar nueva funcion");
            Console.WriteLine("4- Obtener ticket para funcion");
            Console.WriteLine("5- Ver tickets disponibles");
            Console.WriteLine("6- Salir");
            Console.WriteLine("");
        }

        public static void Welcome()
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("==================                                                                                    ==================");
            Console.WriteLine("==================                               Bienvenido a CINE-GBA                                ==================");
            Console.WriteLine("==================                                                                                    ==================");
            Console.WriteLine("========================================================================================================================");
        }
    }
}
