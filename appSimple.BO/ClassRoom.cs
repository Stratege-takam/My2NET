using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple.BO
{
	public class ClassRoom
	{
		public int Id { get; set; }
		public string Code { get; set; }

		public override string ToString()
		{
			return string.Format("Id : {0} \n Code : {1} ", this.Id,
				this.Code);
		}

		public static void ShowMenu()
		{
			Console.WriteLine("\t\t---------------------------------------------");
			Console.WriteLine("\t\t\t 1) Ajouter une classe ");
			Console.WriteLine("\t\t\t 2) Modifier une classe ");
			Console.WriteLine("\t\t\t 3) Supprimer une classe ");
			Console.WriteLine("\t\t\t 4) Consulter la liste des classes ");
			Console.WriteLine("\t\t\t 5) Liste des étudiants de la classe ");
			Console.WriteLine("\t\t\t 6) Retourner au menu principal ");
			Console.WriteLine("\t\t--------------------------------------------");
		}
	}
}
