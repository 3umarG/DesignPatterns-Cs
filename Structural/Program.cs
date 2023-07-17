using Structural.Adapter;
using Structural.Proxy;

internal class Program
{
	private static void Main()
	{
		Console.ForegroundColor = ConsoleColor.Green;

		#region Proxy Design Pattern
		/*
			Console.WriteLine("Applying the Service by using the ConcreteClass Direct :");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			var concreteService = new ConcreteService();
			ImplementService(concreteService);

			Console.WriteLine("\n");


			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Applying the Service by using the Proxy : ");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			var proxy = new Proxy();
			ImplementService(proxy);  // note : we define the proxy as IService so we can pass and use it as Normal Service
		*/
		#endregion

		#region Adapter Design Pattern
		/*

		// Ther service / 3-rd party / legacy code
		WeatherForecastExternalService externalService = new WeatherForecastExternalService();

		// The client that you work and deal with
		WeatherApp app = new WeatherDataAdapter(externalService);

		app.DisplayWeatherData("Canada", new WeatherData());

		*/
		#endregion

		Console.ForegroundColor = ConsoleColor.White;
	}

	private static void ImplementService(IService service)
	{
		service.DoService();
	}
}