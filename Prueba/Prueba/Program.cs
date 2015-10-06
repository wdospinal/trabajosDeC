using System;

namespace Prueba
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			int numeroA = 10;
			int numeroB = 15;
			Numeros n = new Numeros (numeroA,numeroB);

			Console.WriteLine ("Suma" + n.contar());
		}
	}
}
