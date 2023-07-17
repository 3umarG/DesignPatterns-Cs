using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
	/// <summary>
	/// This class acts as Third-party , Library , Legacy Code , Api ... etc
	/// We cannot change the logic of this class or re-construct the structure of it , or change the behaviour of it .
	/// </summary>
	public class WeatherForecastExternalService
	{
		public void GetWeatherDataByLocation(string location , out string condition , out double tempreture)
		{
			condition = "Cloudy";
			tempreture = 30.5;
		}
	}
}
