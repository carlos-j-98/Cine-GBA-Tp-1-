using Cine_GBA.Data.Command;
using Cine_GBA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cine_GBA.Application
{
    public class NewFuncion
    {
        public Salas salas;
        public Peliculas peliculas;
        public Tickets tickets;

        public NewFuncion() 
        {
            Console.Clear();
            this.salas = new Salas();
            this.peliculas = new Peliculas();
            this.tickets = new Tickets();
        }

        public void MakeFuncion() 
        {
            Console.Clear();
            Board();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Bienvenido al creador de funciones");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            int _Pelicula = SelectPeli();
            int _Sala = SelectSala();
            TimeSpan _Horario = new TimeSpan(SelectHour(), SelectMin(), 0);
            DateTime _Fecha = DateTime.Now.Date;

            Funciones _funcion = new Funciones()
            {
                Fecha = _Fecha,
                SalaId = _Sala,
                PeliculaId = _Pelicula,
                Horario = _Horario
            };

            SetFuncion _NuevaFuncion = new SetFuncion();
            _NuevaFuncion.AddFuncion(_funcion);
            Console.WriteLine("Creaste la funcion correctamente papi anda a jugar al lol");

        }
        public void Board()
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("==================                                                                                    ==================");
            Console.WriteLine("==================                          Creador de funciones de CINE-GBA                          ==================");
            Console.WriteLine("==================                                                                                    ==================");
            Console.WriteLine("========================================================================================================================");
        }

        public int SelectPeli() 
        {
            Console.Clear();
            MenuListPeliculas _menuPeliculas = new MenuListPeliculas();
            _menuPeliculas.ToListResumePeliculas();
            Console.WriteLine("");
            Console.WriteLine("¿Que pelicula deseas ver? Indica la opcion numerada no el nombre");
            Console.WriteLine("");
            int _idPeli;
            try
            {
                _idPeli = int.Parse(Console.ReadLine());

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
                _idPeli = SelectPeli();
            }
            return _idPeli;
        }

        public int SelectSala() 
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("En que sala se va a crear la funcion");
            Console.WriteLine("");

            ShowSalas _showSalas = new ShowSalas();
            _showSalas.ToListSalas();

            int _idSala;
            try
            {
                _idSala = int.Parse(Console.ReadLine());
                if (_idSala > _showSalas.CountSalas || _idSala <= 0) 
                {
                    throw new Exception();
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
                _idSala = SelectSala();
            }
            return _idSala;
            
        }

        public int SelectHour() 
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Indique la hora de la funcion, solo hora no minutos, formato: HH");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");

            int _HH;
            try
            {
                _HH = int.Parse(Console.ReadLine());
                if (_HH >= 24 || _HH < 0)
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Opcion incorrecta intente nuevamente");
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Thread.Sleep(2000);
                _HH = SelectHour();
            }
            return _HH;
        }
        public int SelectMin() 
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Indique el minuto de la funcion,solo minutos no segundos, formato: MM");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");

            int _MM;
            try
            {
                _MM = int.Parse(Console.ReadLine());
                if (_MM >= 60 || _MM < 0)
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Opcion incorrecta intente nuevamente");
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------");
                Thread.Sleep(2000);
                _MM = SelectMin();
            }
            return _MM;
        }
    }
}
