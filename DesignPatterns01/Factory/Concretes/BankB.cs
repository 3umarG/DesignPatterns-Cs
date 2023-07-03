using Creational.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Concretes
{
	public class BankB : IBank
	{
		public string WithDraw(double amount)
		{
			return $"You will Draw : {amount}$ from Bank B ...";
		}
	}
}
