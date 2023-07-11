using Structural.Proxy;

internal class Program
{
	private static void Main()
	{
		#region Proxy Design Pattern
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Applying the Service by using the ConcreteClass Direct :");
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		var concreteService = new ConcreteService();
		ImplementService(concreteService);

        Console.WriteLine("\n");


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Applying the Service by using the Proxy : ");
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		var proxy = new Proxy(concreteService);
		ImplementService(proxy);  // note : we define the proxy as IService so we can pass and use it as Normal Service

		#endregion

		Console.ForegroundColor = ConsoleColor.White;
	}

	private static void ImplementService(IService service)
	{
		service.DoService();
	}
}