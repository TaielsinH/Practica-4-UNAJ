using System;

namespace Practica_4_UNAJ
{
	
	public class Hora
	{
		private int hora;
		private int minuto;
		private int segundo;
		public Hora(int hora, int minuto, int segundo)
		{
			this.hora = hora;
			this.minuto = minuto;
			this.segundo = segundo;
			
		}
		public Hora(string cadena)
		{
			char separador = ':';
			string [] partes = cadena.Split(separador);
			hora = int.Parse(partes[0]);
			minuto = int.Parse(partes[1]);
			segundo = int.Parse(partes[2]);
			
			
		}
		
		public void imprimir()
		{
			Console.WriteLine(hora + " HORAS, " + minuto + " MINUTOS Y " + segundo +" SEGUNDOS");
		}
	}
}
