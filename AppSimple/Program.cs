using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple
{
	class Program
	{
		public override string ToString()
		{
			return this.Name;
		}
		public string Name { get; set; }
		static void Main(string[] args)
		{

			#region "Les extensions de type"
			double nombre = 4;
			Console.WriteLine("{0}! = {1}", nombre,
				nombre.factoriel());
			#endregion

			//#region "Using and throw new exception "
			//try
			//{
			//	Console.Write("Entrer un montant : ");
			//	int amount = int.Parse(Console.ReadLine());
			//	//using(var bank1 = new Bank())
			//	//{
			//	//	bank1.Deposit(amount);
			//	//	Console.Write(bank1.Compte);
			//	//}
			//	Bank bank1 = new Bank();
			//	bank1.Deposit(amount);
			//	Console.Write(bank1.Compte);

			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex.Message);
			//}

			//#endregion
			//#region "Exception "
			//try
			//{
			//	Console.Write("Entrer un nombre : ");
			//	int nombre = int.Parse(Console.ReadLine());
			//	Console.Write(nombre);
			//}
			//catch (Exception)
			//{
			//	Console.WriteLine("Vous n'avez pas entré un nombre");
			//}

			//#endregion
			//#region "Instance de la class"
			//Program program1 = new Program()
			//{
			//	Name = " Test simple"
			//};
			//Console.WriteLine(program1);
			//#endregion

			//#region "Utilisation du is "
			//Console.WriteLine("Entrer un nombre  :");
			///* Récuperer la valeur saisie au clavier */
			//var elt = Console.ReadLine();
			//if (int.TryParse(elt, out int result))
			//{
			//	if (result is int)
			//		Console.WriteLine("Le nombre entrer est : {0} ", result);
			//}

			//if (elt is string)
			//	Console.WriteLine("Le nombre entrer est : {0} ", elt);

			//#endregion
			//#region "Boucle "
			//int nbre1 =-1;
			//do
			//{
			//	/* Effacer la console */
			//	System.Console.Clear();
			//	/* Afiicher le texte à  l'utilisateur */
			//	Console.WriteLine("Entrer un nombre positif :");
			//	/* Récuperer la valeur saisie au clavier */
			//	nbre1 = int.Parse(Console.ReadLine());
			//} while (nbre1 < 0);

			//while (nbre1 < 0)
			//{
			//	/* Effacer la console */
			//	System.Console.Clear();
			//	/* Afiicher le texte à  l'utilisateur */
			//	Console.WriteLine("Entrer un nombre positif :");
			//	/* Récuperer la valeur saisie au clavier */
			//	nbre1 = int.Parse(Console.ReadLine());
			//}
			///* Afficher le nombre */
			//Console.WriteLine("Le nombre entrer est : {0} ",
			//	nbre1);
			//#endregion
			//#region "Egalité "
			//Account a3 = new Account("125");
			//Account a4 = new Account("125");

			//if (a3 == a4)
			//	Console.WriteLine("Objects are equal");
			//else
			//	Console.WriteLine("Objects are not equal");


			//if (a3.v.Equals(a4.v))
			//	Console.WriteLine("Objects are equal");
			//else
			//	Console.WriteLine("Objects are not equal");
			//int X, Y;
			//X = 5;
			//Y = 5;
			//if (X == Y)
			//	Console.WriteLine("X == Y");
			//else
			//	Console.WriteLine("X != Y");
			//#endregion
			//#region "Type de données"
			//int A, B;
			//A = 3;
			//B = A;
			//A = 5;
			//Console.WriteLine("A = {0} B = {1} ", A, B);

			//Account account1 = new Account();
			//Account account2 = account1;
			//account1.Name = "Simple test";
			//account2.Password = "Test";
			//account1.Password = "Other";
			//Console.WriteLine("account1.Name = {0} account2.Name = {1} ",
			//	account1.Name, account2.Name);
			//Console.WriteLine("account1.Password = {0} account2.Password = {1} ",
			//	account1.Password, account2.Password);
			//#endregion

			//#region "Surcharge"
			//	Console.WriteLine("La somme est : {0} ", add());
			//	Console.WriteLine("La somme est : {0} ", add(nbre2: 6));
			//	Console.WriteLine("La somme est : {0} ", add(1, 2));
			//	Console.WriteLine("La somme est : {0} ", add(1, 2, 3));
			//	Console.WriteLine("La somme est : {0} ", add(1, 2, 4, 5));
			//	Console.WriteLine("La somme est : {0} ", add(new int[] { 1, 2, 3, 4, 5, 6 }));
			//#endregion


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
		public string v;

		public Account(string v)
		{
			this.v = v;
		}

		public string Name { get; internal set; }
		public string Password { get; internal set; }
	}
}
