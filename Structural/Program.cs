using Structural.Adapter;
using Structural.Decorator;
using Structural.Facade;
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

		#region Decorator Design Pattern 
		/*
		Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Using Order Processor without using Decorator Pattern : ");

        Order order = new() { ID = 1, Count = 0, Price = 563 };
		IOrderProcessor concreteOrderProcssor = new OrderProcessorConcrete();
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(concreteOrderProcssor.Process(order));

		Console.WriteLine("\n");

        Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Using Order Processor with using Decorator Pattern : ");

		Console.ForegroundColor = ConsoleColor.Green;
		concreteOrderProcssor = new OrderProcessorExceptionHandlingDecorator(concreteOrderProcssor);
		concreteOrderProcssor = new OrderProcessorLoggingDecorator(concreteOrderProcssor);
        Console.WriteLine(concreteOrderProcssor.Process(order));
		*/
		#endregion
		
		#region Facade Design Pattern

		var system = new ComplexSystemServiceClass();
		var facade = new PaymentFacade(system);

		// as a client , you don't need to deal directly with the complex service 
		// by Facade you have as interface that provide only specific methods and access to what you need or want.
		facade.Pay();

		#endregion
		Console.ForegroundColor = ConsoleColor.White;
	}

	private static void ImplementService(IService service)
	{
		service.DoService();
	}
}