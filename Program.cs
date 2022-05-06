using System;

namespace Practica_4_UNAJ
{
	class Program
	{
		public static void Main(string[] args)
		{
			Hora h = new Hora(23, 30, 15);
			Hora h2 = new Hora("13:30:15");
			Persona p = new Persona("Taiel Ojeda Studer", 19, 33333333);
			
			h.imprimir();
			h2.imprimir();
			
			p.imprimirPersona();
			
			Console.ReadKey(true);
		}
	}
}