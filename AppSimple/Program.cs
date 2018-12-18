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


			//#region "Surcharge"
			//	Console.WriteLine("La somme est : {0} ", add());
			//	Console.WriteLine("La somme est : {0} ", add(nbre2: 6));
			//	Console.WriteLine("La somme est : {0} ", add(1, 2));
			//	Console.WriteLine("La somme est : {0} ", add(1, 2, 3));
			//	Console.WriteLine("La somme est : {0} ", add(1, 2, 4, 5));
			//	Console.WriteLine("La somme est : {0} ", add(new int[] { 1, 2, 3, 4, 5, 6 }));
			//#endregion
			#region "Type de données"
			int A, B;
			A = 3;
			B = A;
			A = 5;
			Console.WriteLine("A = {0} B = {1} ", A, B);

			Account account1 = new Account();
			Account account2 = account1;
			account1.Name = "Simple test";
			account2.Password = "Test";
			account1.Password = "Other";
			Console.WriteLine("account1.Name = {0} account2.Name = {1} ",
				account1.Name, account2.Name);
			Console.WriteLine("account1.Password = {0} account2.Password = {1} ",
				account1.Password, account2.Password);
			#endregion
			Console.ReadKey();
		}

		#region "Surcharge"
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
		#endregion

	}

	internal class Account
	{
		public string Name { get; internal set; }
		public string Password { get; internal set; }
	}
}
