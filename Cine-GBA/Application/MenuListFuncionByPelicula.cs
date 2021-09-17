using Cine_GBA.Data.Models;
using Cine_GBA.Data.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cine_GBA.Application
{
	class MenuListFuncionByPelicula
	{

		public MenuListFuncionByPelicula() 
		{

		}

		public void SelectFuncion() 
		{
			Console.Clear();
			Board();
			
			Console.WriteLine("");
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("");
			Console.WriteLine("Escriba el nombre de la pelicula que desea saber si existe una funcion");
			Console.WriteLine("");
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("");

			DisplayPeliculas();

			Console.Write("Deseo ver la pelicula: ");
			
			try 
			{
				string titulo = Console.ReadLine();
				DisplayFuncion(titulo);
			}
			catch (Exception) 
			{
				Console.WriteLine("");
				Console.WriteLine("La pelicula indicada no existe o no pertenece a ninguna funcion en cartelera");
				Console.WriteLine("Regresando al menu de eleccion de funciones por peliculas");
				Thread.Sleep(3000);
				SelectFuncion();
			}

		}
		public void Board()
		{
			Console.Clear();
			Console.WriteLine("========================================================================================================================");
			Console.WriteLine("==================                                                                                    ==================");
			Console.WriteLine("==================                             Ver funciones de peliculas                             ==================");
			Console.WriteLine("==================                                                                                    ==================");
			Console.WriteLine("========================================================================================================================");
		}
		public void DisplayPeliculas()
		{
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("");
			Console.WriteLine("Peliculas en cartelera");
			Console.WriteLine("");
			ListPeliculas _listPeliculas = new ListPeliculas();
			List<Peliculas> aux = _listPeliculas.ToList();
			foreach (Peliculas objeto in aux)
			{
				Console.WriteLine("\n Titulo: {0} ",objeto.Titulo);
			}

		}
		public void DisplayFuncion(string titulo) 
		{
			Console.Clear();
			Board();
			GetPelicula getPelicula = new GetPelicula();
			Peliculas _pelicula = getPelicula.GetPeliculaByTitulo(titulo);
			ListFuncionesByPeliculas nueva = new ListFuncionesByPeliculas();
			List<Funciones> getListPeliculas = nueva.ToList(_pelicula.PeliculaId);
			Console.WriteLine("");
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("");
			Console.WriteLine("Informacion de la pelicula");
			Console.WriteLine("");
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("");

			Console.WriteLine("| Titulo: {0}", _pelicula.Titulo);
			Console.WriteLine("| Sinopsis: {0}", _pelicula.Sinopsis);

			Console.WriteLine("");
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("");
			Console.WriteLine("Informacion de la funcion");
			Console.WriteLine("");
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("");

			if (getListPeliculas.Count > 0)
            {
				foreach (Funciones obj in getListPeliculas)
				{
					Console.WriteLine("| Fecha: {0}", obj.Fecha);
					Console.WriteLine("| Horario: {0}", obj.Horario);
					Console.WriteLine("| Sala: {0}", obj.SalaId);
					Console.WriteLine("");
					Console.WriteLine("--------------------------------------------------------------------");
					Console.WriteLine("");
				}
			}
            else 
			{
				throw new Exception();
			}

			Console.WriteLine("Aprete un boton para volver al menu principal");
			Console.ReadKey();
		}
	}
}
