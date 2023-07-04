﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.AbstractFactory.Interfaces
{
	public interface IFurnitureFactory
	{
		IChair CreateChair();
		ISofa CreateSofa();
		ITable CreateTable();
	}
}
