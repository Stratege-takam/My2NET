using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple.BO
{
    public abstract class Person
    {
		[Key]
		public int Id { get; set; }
		public DateTime? BirthOfDate { get; set; }

		[Required]
		[MinLength(2)]
		public string Name { get; set; }

		[Required]
		public char Gender { get; set; }

		public string Firstname { get; set; }

		public string Fullname => string.Format("{0} {1}", this.Firstname, this.Name);


		public override string ToString()
		{
			return string.Format("Id = {0} \n Name = {1}   \n Gender = {2}",
		       this.Id, this.Fullname, this.Gender);
		}

		public abstract void ShowStatus();

		public virtual string GetStatus()
		{
			if( this is Student)
			{
				return "Student";
			}
			else if (this is Professor)
			{
				return "Professor";
			}
			return "Person";
		}

		public static void Display(IEnumerable<Person> people)
		{
			foreach (var item in people)
			{
				Console.WriteLine(item);
			}
		}
	}
}
