using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
	public class OrderProcessorLoggingDecorator : IBaseDecorator
	{
		public IOrderProcessor orderProcessor { get; private set; }

        public OrderProcessorLoggingDecorator(IOrderProcessor orderProcessor)
        {
            this.orderProcessor = orderProcessor;
        }

        public string Process(Order order)
		{
			return $"Logging Decorator : ( {orderProcessor.Process(order)} ).";
		}


	}
}
