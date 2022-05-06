using System;

namespace Practica_4_UNAJ
{
	class Program
	{
		public static void Main(string[] args)
		{
			Hora h = new Hora(23, 30, 15);
			Hora h2 = new Hora("13:30:15");
			
			h.imprimir();
			h2.imprimir();
			
			Console.ReadKey(true);
		}
	}
}