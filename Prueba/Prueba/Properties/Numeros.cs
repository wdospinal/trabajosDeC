using System;

namespace Prueba
{
	public class Numeros
	{
		private int numeroA;
		private int numeroB;

		public int NumeroA {
			get{ return numeroA;}
			set{ numeroA = value;}
		}

		public int NumeroB {
			get{ return numeroB;}
			set{ numeroB = value;}
		}

		public Numeros (int numeroA, int numeroB)
		{
			this.numeroA = numeroA;
			this.numeroB = numeroB;
		}

		public int contar ()
		{
			return numeroA + numeroB;
		}
	}
}
