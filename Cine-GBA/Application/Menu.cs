using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Esa opcion no existe. Intente nuevamente");
                Thread.Sleep(2000);
                MenuInit();
            }

        }
        public void ListOptions()
        {
            
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1- Lista de peliculas");
            Console.WriteLine("5- Salir");
            Console.WriteLine("");
        }

        public void Welcome() 
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
