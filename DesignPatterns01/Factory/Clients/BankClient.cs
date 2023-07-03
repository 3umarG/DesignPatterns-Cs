using Creational.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Clients
{
	public class BankClient
	{
		public static string Draw(IBank bank , double amount)
		{
			return bank.WithDraw(amount);
		}
	}
}
