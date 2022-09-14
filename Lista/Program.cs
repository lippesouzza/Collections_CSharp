using System;
using System.Collections.Generic;

namespace Lista
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> lista = new List<string>();

			lista.Add("Gatos");
			lista.Add("Cachorros");
			lista.Add("Ratos");
			lista.Add("Lagartos");

			lista.Insert(1, "Borboletas");

			lista.Remove("Lagartos");

			lista.RemoveAt(1);

			foreach (string item in lista)
			{
				Console.WriteLine($"Boaz tem {item}!");
			}
		}
	}
}