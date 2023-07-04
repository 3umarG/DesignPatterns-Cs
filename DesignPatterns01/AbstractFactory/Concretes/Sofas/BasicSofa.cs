using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Concretes.Sofas
{
	internal class BasicSofa : ISofa
	{
		public string GetModel()
		{
			return "Basic Sofa";
		}
	}
}
