using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Prototype
{
	public class TempEmployee : EmployeePrototype
	{
		public override EmployeePrototype DeepClone()
		{
			var emp = new TempEmployee();

			// shallow copy
			emp = (TempEmployee) this.MemberwiseClone();

			// start to make it Deep Copy
			emp.Name = this.Name;
			emp.EmpAddress = new Address { 
				Country = this.EmpAddress.Country,
				City = this.EmpAddress.City,
				Street = this.EmpAddress.Street,	
			};

			return emp;
		}

		/// Create new instance with its Reference types related to old instance
		public override EmployeePrototype ShallowClone()
		{
			return (TempEmployee) this.MemberwiseClone();
		}
	}
}
