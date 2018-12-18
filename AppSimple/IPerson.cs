using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple
{
	interface IPerson
	{
		Person add(Person person);
		Person Edit(Person person);
		void Delete(Person person);
	}
}
