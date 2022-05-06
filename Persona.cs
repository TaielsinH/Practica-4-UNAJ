using System;

namespace Practica_4_UNAJ
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		private string nombre;
		private int edad;
		private int DNI;
		private DateTime FechaNacimiento;
		
		public Persona(string nombre, int edad, int DNI)
		{
			this.nombre = nombre;
			this.edad = edad;
			this.DNI = DNI;
		}
		public void imprimirPersona()
		{
			Console.WriteLine(nombre +" (" + edad + ") " + DNI);
		}
		public Persona(string cadena)
		{
			char separador = '	';
			string[] partes = cadena.Split(separador);
			this.nombre = partes[0];
			this.DNI = int.Parse(partes[1]);
			this.edad = int.Parse(partes[2]);	                      
		}
		public Persona(string nombre, int DNI, DateTime FechaNacimiento)
		{
			
			DateTime hoy = DateTime.Today(); //Error: Non-invocable member 'System.DateTime.Today' cannot be used like a method
			this.nombre = nombre;
			this.DNI = DNI;
			this.FechaNacimiento = FechaNacimiento;
			
			TimeSpan diferencia = hoy - FechaNacimiento;
			int dias = (int) Math.Floor(diferencia.TotalDays);
		}
	}
}
