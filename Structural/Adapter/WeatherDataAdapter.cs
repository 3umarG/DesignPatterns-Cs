
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Adapter
{
	/// <summary>
	/// This class will be Adapt the data from WeatherApp to be suitable to use at WeatherForecastService
	/// 1- We can implement Adapter by using Composition : Inherit the Client Class and wraps the service.
	/// </summary>
	public class WeatherDataAdapter : WeatherApp
	{
		private readonly WeatherForecastExternalService _service;

		public WeatherDataAdapter(WeatherForecastExternalService service)
		{
			_service = service;
		}

		/// <summary>
		/// This method must get the data as the Client do because the class inherits from Client class 
		/// and to be usable as Client instance
		/// and make complex convert/extraction to the data as service need to deal with .
		/// 
		/// The two end of this communication : WeatherApp & Service don't know anything about each other
		/// The way of communication is the Adapter .
		/// Each end work as the Data it needs , no one suffer about the form of Data.
		/// </summary>
		/// <param name="location"></param>
		/// <param name="data"></param>
		override public void DisplayWeatherData(string location, WeatherData dataResult)
		{
			_service.GetWeatherDataByLocation(location, out string condition, out double temperature);

			dataResult.Condition = condition;
			dataResult.Tempreture = temperature;

			base.DisplayWeatherData(location, dataResult);
		}
	}
}
