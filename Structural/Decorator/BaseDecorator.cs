using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
	public interface IBaseDecorator : IOrderProcessor
	{
		public IOrderProcessor orderProcessor { get; }
	}
}
