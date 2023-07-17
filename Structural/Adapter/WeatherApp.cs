using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
	/// <summary>
	/// That represents the Client class that deals with 3-rd party / legacy code to get results and returns to the user
	/// Always any changes will be applied inside this class
	/// </summary>
	public class WeatherApp
	{
		public virtual void DisplayWeatherData(string location, WeatherData dataResult)
		{
            Console.WriteLine($"Location : {location}");
            Console.WriteLine($"Condition : {dataResult.Condition}");
            Console.WriteLine($"Tempreture : {dataResult.Tempreture} C");
        }
	}
}
