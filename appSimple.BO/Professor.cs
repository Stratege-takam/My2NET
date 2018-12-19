using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple.BO
{
	public class Professor:Person
	{
		public DateTime HireDate { get; set; }
		public double Salary { get; set; }

		public override void ShowStatus()
		{
			Console.WriteLine(this.GetStatus());
		}

		public override string GetStatus()
		{
			return string.Format("I am a {0}", base.GetStatus());
		}
	}
}
