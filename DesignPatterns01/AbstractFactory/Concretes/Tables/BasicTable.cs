using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Concretes.Tables
{
	public class BasicTable : ITable
	{
		public string GetModel()
		{
			return "Basic Table";
		}
	}
}
