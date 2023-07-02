using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
	// the bridge between the Client and the Builder
	// only know the steps of building specific object , without needing to know the details about every step
	public class Director
	{
		// builder : the specific order from the client
		private readonly IBuilder _builder;

		public Director(IBuilder builder)
		{
			_builder = builder;
		}

		// the order from the Client
		public void Build1()
		{
			// Contains the steps of building the order without need to know the implementation ...
			_builder.BuildStep1();
			_builder.BuildStep4();
			_builder.BuildStep2();
			_builder.BuildStep3();

		}

		public void Build2()
		{
			// Contains the steps of building the order without need to know the implementation ...
			_builder.BuildStep1();
			_builder.BuildStep2();
			_builder.BuildStep3();
			_builder.BuildStep4();

		}
	}
}
