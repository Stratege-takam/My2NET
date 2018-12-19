using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple
{
	public class Bank
	{
		public int Compte { get; set; }
		public void Deposit(int amount)
		{
			if (amount < 0)
			{
				throw new Exception("Le montant ne peux pas être négatif");
			}
			this.Compte += amount;
		}
	}
}
