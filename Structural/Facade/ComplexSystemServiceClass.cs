using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
	/// <summary>
	/// That class represents the Framework , 3-rd part library , or any service that do a lot of stuff
	/// Client actually doesn't need all these services , he only needs some of these features to do his work
	/// </summary>
	public class ComplexSystemServiceClass
	{
		public bool CheckStockAvailability() => true;

		public void PlaceOrder()
		{
			Console.WriteLine("Processing the order in Queue ...");
		}

		public void CreateInvoice()
		{
			Console.WriteLine("Creating Invoice for Order ...");
		}

		public void PaymentProcessing()
		{
			Console.WriteLine("Starting the Processing of Payment Operation ...\n");
			Console.WriteLine("The Processing Ends !! \n");
		}

		public void SendNotifications()
		{
			Console.WriteLine("Your Payment Process has been finished successfuly , We will send confirm code to your Email Address ...");
		}
	}
}
