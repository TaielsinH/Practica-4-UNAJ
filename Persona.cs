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
	}
}
