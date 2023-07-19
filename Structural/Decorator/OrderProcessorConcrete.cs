using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
	public class OrderProcessorConcrete : IOrderProcessor
	{
		public string Process(Order order)
		{
			if (order.Count == 0)
				throw new Exception("Invalid Order !!");
			Thread.Sleep(1000);
			return "Processing Order Done !!";
		}
	}
}
