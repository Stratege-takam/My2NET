using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple.BO
{
	public class Student:Person
	{
		
		public double? Rating { get; set; }

		[Required]
		public int CampusId { get; set; }

		[Required]
		public int ClassRoomId { get; set; }

		public ClassRoom ClassRoom { get; set; }

		public override string ToString()
		{
			return "";
		}


		public override void ShowStatus()
		{
			Console.WriteLine(this.GetStatus());
		}

		public override string GetStatus()
		{
			return string.Format("I am a {0}", base.GetStatus());
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


		public static void Display(IEnumerable<Student> Students)
		{
			int i = 1;
			foreach (var item in Students)
			{
				Console.WriteLine("{0}) CampusId = {1} ,  {2}", i,item.CampusId, item.Fullname);
				i++;
			}
		}

	}
}
