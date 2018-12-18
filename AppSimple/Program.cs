using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("La somme est : {0} ", add());
			Console.WriteLine("La somme est : {0} ", add(nbre2:6));
			Console.WriteLine("La somme est : {0} ", add(1,2));
			Console.WriteLine("La somme est : {0} ", add(1,2,3));
			Console.WriteLine("La somme est : {0} ", add(1,2,4,5));
			Console.WriteLine("La somme est : {0} ", add(new int[]{1,2,3,4,5,6 }));
			Console.ReadKey();
		}

		public static int add(int nbre1=3,int nbre2=1)
		{
			return nbre1 + nbre2;
		}

		public static int add(params int[] nbs)
		{
			int somme = 0;
			if (nbs.Length > 0)
			{
				foreach (int i in nbs)
				{
					somme += i;
				}
			}
			return somme;
		}

	}
}
