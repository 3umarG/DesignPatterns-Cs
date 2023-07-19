using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
	public interface IOrderProcessor
	{
		public string Process(Order order);
	}
}
