using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Facade
{
	/// <summary>
	/// Facade : Provide Interface for user/client to deal with complex Systems,Frameworks , 3-rd part library ...
	/// Facade : make the client deal with small part of the Complex System as he needs ...
	/// It manages all class , objects , lifecycles , the order of calling methods , exception handling 
	/// and return the result to the client as peace of cake ...
	/// </summary>
	public class PaymentFacade
	{
		private readonly ComplexSystemServiceClass _system;

		public PaymentFacade(ComplexSystemServiceClass system)
		{
			_system = system;
		}

		public void Pay()
		{
			if (_system.CheckStockAvailability())
			{
				_system.PlaceOrder();
				_system.PaymentProcessing();
				_system.CreateInvoice();
				_system.SendNotifications();
			}
		}
	}
}
