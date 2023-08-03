using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.StudentEx
{
	public class Student
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public string Address { get; set; }

		public double GPA { get; set; }


		private Student()
		{

		}

		public static Builder builder()
		{
			return new Builder();
		}

		public class Builder
		{
			private readonly Student student;

			public Builder()
			{
				student = new Student();
			}

			public Builder Name(string name)
			{
				this.student.Name = name;
				return this;
			}

			public Builder Age(int age)
			{
				student.Age = age;
				return this;
			}

			public Builder Addrees(string address)
			{
				student.Address = address;
				return this;
			}

			public Builder GPA(double gpa)
			{
				student.GPA = gpa;
				return this;
			}

			public Student build()
			{
				return student;
			}

		}

	}
}
