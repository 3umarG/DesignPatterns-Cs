using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Singleton.CounterExample
{
	public class Counter
	{
		public int Count { get; private set; } = 0;

		// make it null for Lazy initialization
		private static Counter? instance = null ;

		// make the constructor private for deny the access of it
		private Counter() { }

		public static Counter GetInstance()
		{
			if(instance == null)
			{
				instance = new Counter();
			}

			return instance;
		}
		public void AddOne()
		{
			Count++;
		}
	}
}
