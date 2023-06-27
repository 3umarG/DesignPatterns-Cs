using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.CounterExample
{
	public class Counter
	{
		public int Count { get; set; } = 0;

		public void AddOne()
		{
			Count++;
		}
	}
}
