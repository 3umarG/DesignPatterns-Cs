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
	internal class BasicFurnitureFactory : IFurnitureFactory
	{
		public IChair CreateChair()
		{
			return new BasicChair();
		}

		public ISofa CreateSofa()
		{
			return new BasicSofa();
		}

		public ITable CreateTable()
		{
			return new BasicTable();
		}
	}
}
