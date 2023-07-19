using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
	public class OrderProcessorExceptionHandlingDecorator : IBaseDecorator
	{
		public IOrderProcessor orderProcessor { get; private set; }

        public OrderProcessorExceptionHandlingDecorator(IOrderProcessor orderProcessor)
        {
            this.orderProcessor = orderProcessor;	
        }
        public string Process(Order order)
		{
			try
			{
				return orderProcessor.Process(order);
			}catch(Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
