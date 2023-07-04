using Creational.AbstractFactory.Concretes.Chairs;
using Creational.AbstractFactory.Concretes.Sofas;
using Creational.AbstractFactory.Concretes.Tables;
using Creational.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Concretes.Factories
{
	internal class ModernFurnitureFactory : IFurnitureFactory
	{
		public IChair CreateChair()
		{
			return new ModernChair();
		}

		public ISofa CreateSofa()
		{
			return new ModernSofa();
		}

		public ITable CreateTable()
		{
			return new ModernTable();
		}
	}
}
