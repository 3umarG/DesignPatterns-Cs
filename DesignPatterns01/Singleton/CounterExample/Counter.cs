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
		private static Counter? instance = null;

		// Lock Object for Locking till the current thread finish its execution
		// is used as a lock to ensure that only one thread can enter the critical section where the instance creation occurs.
		private static readonly Object LockObj = new();

		// make the constructor private for deny the access of it
		private Counter() { }

		public static Counter GetInstance()
		{
			// Double Check : to minimize the performance impact of acquiring a lock unnecessarily.
			if (instance == null)
			{
				lock (LockObj)
				{
					if (instance == null)
						instance = new Counter();
				}
			}

			return instance;
		}
		public void AddOne()
		{
			Count++;
		}
	}
}
