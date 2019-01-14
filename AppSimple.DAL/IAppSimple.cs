using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSimple.DAL
{
	public interface IAppSimple<T>
	{
		T Add(T obj);
		T Edit(T obj);
		void Remove(T obj);

		IEnumerable<T> FindAll();
	}
}
