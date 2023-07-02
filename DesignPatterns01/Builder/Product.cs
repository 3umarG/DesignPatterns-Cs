using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
	public class Product
	{
		private readonly List<string> _parts;

		public Product()
		{
			_parts = new List<string>();
		}

		public void Add(string part)
		{
			_parts.Add(part);
		}

		public void Reset() => _parts.Clear();

		public override string ToString()
		{
			var result = new StringBuilder();
			foreach (var part in _parts)
			{
				result.AppendLine(part);
			}
			return result.ToString();
		}
	}
}
