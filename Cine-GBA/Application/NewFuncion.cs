using Cine_GBA.Data.Command;
using Cine_GBA.Data.Models;
using Cine_GBA.Data.Queries;
using System;
using System.Threading;

namespace Cine_GBA.Application
{
    public class NewFuncion
    {
        public int horaAux;
        public int mesAux;
        public NewFuncion()
        {
            Console.Clear();
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
            DateTime _Fecha = new DateTime(2021, SelectMonth(), SelectDay());
            HoursAvailable(_Sala, _Fecha, _Horario);
            if (HoursAvailable(_Sala, _Fecha, _Horario))
            {
                Funciones _funcion = new Funciones()
                {
                    Fecha = _Fecha,
                    SalaId = _Sala,
                    PeliculaId = _Pelicula,
                    Horario = _Horario
                };
                SetFuncion _NuevaFuncion = new SetFuncion();
                _NuevaFuncion.AddFuncion(_funcion);
                Console.WriteLine("Funcion creada correctamente");
                Thread.Sleep(3000);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El horario de la funcion que usted eligio esta ocupado intente con otro");
                Thread.Sleep(3000);
            }
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
            horaAux = _HH;
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
                Console.Write(horaAux + ":");
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
        public int SelectMonth()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Indique el mes de la funcion, formato: MM");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");

            int _MM;
            try
            {
                _MM = int.Parse(Console.ReadLine());
                if (_MM > 12 || _MM < 0)
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
                _MM = SelectMonth();
            }
            mesAux = _MM;
            return _MM;
        }
        public int SelectDay()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Indique el dia de la funcion, formato: DD");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");

            int _DD;
            try
            {
                Console.Write("2021/" + mesAux + "/");
                _DD = int.Parse(Console.ReadLine());
                if (_DD >= 31 || _DD < 0)
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
                _DD = SelectDay();
            }
            return _DD;
        }

        public bool HoursAvailable(int idSala, DateTime Fecha, TimeSpan Horario)
        {
            ListFunciones _hoy = new ListFunciones();
            TimeSpan rangoHorario = new TimeSpan(2, 30, 0);
            Horario = Horario.Add(rangoHorario);
            foreach (Funciones x in _hoy.ToListFuncionesByFechaSala(idSala, Fecha))
            {
                int comp = TimeSpan.Compare(Horario, x.Horario);
                switch (comp)
                {
                    case (-1):
                        if (comp < 150)
                        {
                            return false;
                        }
                        break;
                    case (0):
                        return false;
                    case (01):
                        if (comp < 150)
                        {
                            return false;
                        }
                        break;
                }
            }
            return true;
        }
    }
}
