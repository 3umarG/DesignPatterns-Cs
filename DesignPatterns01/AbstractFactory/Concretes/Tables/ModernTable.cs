using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Concretes.Tables
{
	internal class ModernTable : ITable
	{
		public string GetModel()
		{
			return "Modern Table";
		}
	}
}
