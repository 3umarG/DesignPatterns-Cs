using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
	/// The Concrete class that knows about the implementation of the Builder methods 
	/// only specific on that type of IBuilder .
	public class HouseBuilder : IBuilder
	{
		private readonly Product _product;

        public HouseBuilder()
        {
            _product = new Product();
        }
        public void BuildStep1()
		{
			_product.Add("Step 1 : Windows");
		}

		public void BuildStep2()
		{
			_product.Add("Step 2 : Doors");
		}

		public void BuildStep3()
		{
			_product.Add("Step 3 : Rooms");
		}

		public void BuildStep4()
		{
			_product.Add("Step 4 : Garden");
		}

		public override string ToString()
		{
			return _product.ToString();
		}
	}
}
