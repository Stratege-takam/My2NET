using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple.BO
{
	public class Student
	{
		public int Id { get; set; }
		public DateTime? BirthOfDate { get; set; }
		public string Name { get; set; }
		public char Gender { get; set; }
		public string Firstname { get; set; }
		public double Rating { get; set; }

		public string Fullname => string.Format("{0} {1}", this.Firstname, this.Name);


		public override string ToString()
		{
			return 
		string.Format("Id = {0} \n Name = {1} \n Firstname : {2}  \n Rating = {3}",
		this.Id, this.Name, this.Firstname, this.Rating);
		}


		public static void ShowMenu()
		{
			Console.WriteLine("\t\t---------------------------------------------");
			Console.WriteLine("\t\t\t 1) Ajouter un étudiant ");
			Console.WriteLine("\t\t\t 2) Modifier une étudiant ");
			Console.WriteLine("\t\t\t 3) Supprimer une étudiant ");
			Console.WriteLine("\t\t\t 4) Consulter la liste des étudiant ");
			Console.WriteLine("\t\t\t 5) Retourner au menu principal ");
			Console.WriteLine("\t\t--------------------------------------------");
		}

	}
}
