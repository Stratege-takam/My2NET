using System;
using System.Collections.Generic;
using System.Linq;
namespace AppSimple
{
	class Program
	{
		public override string ToString()
		{
			return this.Name;
		}
		public string Name { get; set; }

		public static double DoProduct(double nbre1, double nbre2)
		{
			return nbre1 * nbre2;
		}

		public delegate double HelpProduct(double nbre1, double nbre2);
		public static double DoPow ( HelpProduct helpProduct,params double[] nbres)
		{
			double result = 0;
			if(nbres != null)
			{
				result = 1;
				foreach(var nb in nbres)
				{
					result = helpProduct(nb, result);
				}
			}
			return result;
		}

		static void Main(string[] args)
		{

			#region "Delegue"
				Console.WriteLine(DoPow(DoProduct,5, 6, 7, 9));
			#endregion




			//#region "LINQ"
			//List<Student> students = new List<Student>()
			//{
			//	new Student(){ Firstname= "maxime",Name = "Siguier",
			//		Id = 1, BirthOfDate= DateTime.Now,
			//		Gender = 'F',  Rating= 20   },

			//	new Student(){ Firstname= "amaury",Name = "Morange",
			//		Id = 2, BirthOfDate= null,
			//		Gender = 'M',  Rating= 30   },

			//	new Student(){ Firstname= "thomas",Name = "Jasmin",
			//		Id = 3, BirthOfDate= null,
			//		Gender = 'F',  Rating= 47.5  },

			//	new Student(){ Firstname= "fabien",Name = "Kremer",
			//		Id = 4, BirthOfDate= DateTime.Now,
			//		Gender = 'F',  Rating= 7.5  },

			//	new Student(){ Firstname= "gael",Name = "Prun",
			//		Id = 5, BirthOfDate= DateTime.Now,
			//		Gender = 'M',  Rating= 35  },

			//	new Student(){ Firstname= "jason",Name = "Sejean",
			//		Id = 6, BirthOfDate=null,
			//		Gender = 'M',  Rating= 12.5  },
			//};


			//var l = from Student in students
			//		where Student.BirthOfDate != null && 
			//		Student.Firstname.Contains("n")
			//		orderby Student.Id descending
			//		select 
			//		Student.Fullname.ToUpper();
			//Console.WriteLine("Première méthode");
			//foreach( var name in l)
			//{
			//	Console.WriteLine(name);
			//}

			//var l2 = students
			//	.Where(student => student.BirthOfDate != null
			//&& student.Firstname.Contains("n")
			//).OrderByDescending(s => s.Id)
			//.Select(st => st.Fullname.ToUpper());
			//Console.WriteLine("Deuxième méthode");
			//foreach (var name in l)
			//{
			//	Console.WriteLine(name);
			//}
			//#endregion

			//#region "Utilisation des listes"
			//List<string> MyList = new List<string>()
			//{
			//	"Thomas",
			//	"Morange",
			//	"Maxime",
			//	"Jason"
			//};
			//MyList.AddRange(new List<string>() {
			//	"Gael",
			//	"Fabien",
			//	"Felix"});

			//MyList.Add("Danick");

			//foreach (var name in MyList.SortByLastLetter())
			//{
			//	Console.WriteLine(name);
			//}

			//#endregion

			//#region "CompareTo"
			//string chaine1 = "test";
			//string chaine2 = "toto";
			//if (chaine1.CompareTo(chaine2) == 0)
			//{
			//	// egale
			//}
			//else if (chaine1.CompareTo(chaine2) > 0)
			//{
			//	// chaine1  est plus grande 
			//}
			//else
			//{
			//	// chaine1  est inferieur 
			//}
			//#endregion
			//#region "Les extensions de type"
			//double nombre = 4;
			//Console.WriteLine("{0}! = {1}", nombre,
			//	nombre.factoriel());
			//#endregion

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
