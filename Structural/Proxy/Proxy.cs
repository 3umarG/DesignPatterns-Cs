using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Proxy
{
	/// <summary>
	/// Initialize the Proxy as IService to deal with it as Service and can pass it as Class Service
	/// </summary>
	public class Proxy : IService
	{
		private ConcreteService _service;

		

		private bool CheckAccess()
		{
            Console.WriteLine("Proxy : Check the Access before do the DoService() method ...");
			return true;
        }

		private void DoCaching()
		{
            Console.WriteLine("Proxy : Do Caching after do the DoService() method ...");
        }


		private void Logging()
		{
            Console.WriteLine("Proxy : Do Logging for the result after the DoService() method ...");
        }

		/// <summary>
		/// In that method we don't apply different implementation
		/// we only do some work around the DoService() method on the ConcreteClass
		/// this work include : checking for access , logging , caching , lazy initialization ... etc
		/// </summary>
		public void DoService()
		{
			// lazy initialization
			_service ??= new ConcreteService();

			if (CheckAccess())
			{
				_service.DoService();
				DoCaching();
				Logging();
			}
		}
	}
}
