using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
	public abstract class EmployeePrototype
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public Address EmpAddress { get; set; }

		public override string ToString()
		{
			return @$"
					ID : {this.ID}
					Employee Name : {this.Name}
					Employee Address : {this.EmpAddress.Country} , {this.EmpAddress.City} , {this.EmpAddress.Street}
					";
		}

		public abstract EmployeePrototype ShallowClone();
		public abstract EmployeePrototype DeepClone();
	}
}
