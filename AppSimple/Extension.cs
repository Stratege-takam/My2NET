﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple
{
	public static class Extension
	{
		public static double factoriel(this double nombre)
		{
			return nombre==0? 1: nombre * factoriel(nombre - 1);
		}

		public static List<string> SortByLastLetter(this List<string> MyList)
		{
			return MyList?.OrderBy(f => f.LastOrDefault()).ToList();
		}
	}
}
