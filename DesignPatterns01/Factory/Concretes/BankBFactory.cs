using Creational.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Concretes
{
	public class BankBFactory : IBankFactory
	{
		public IBank FactoryMethod()
		{
			return new BankB();
		}
	}
}
