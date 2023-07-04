using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Concretes.Sofas
{
	public class ModernSofa : ISofa
	{
		public string GetModel()
		{
			return "Modern Sofa";
		}
	}
}
