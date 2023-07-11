using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy
{
	/// This class has the role of doing and implementing the Service only 
	/// Any additional work like caching , requirements ... etc , shouldn't be include in this class .
	public class ConcreteService : IService
	{
		public void DoService()
		{
            Console.WriteLine("Concrete Service Class start doing the service ...");
        }
	}
}
