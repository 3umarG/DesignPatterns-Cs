using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
	public interface IBuilder
	{
		void BuildStep1();
		void BuildStep2();
		void BuildStep3();
		void BuildStep4();
	}
}
