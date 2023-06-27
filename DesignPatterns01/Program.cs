using Creational.Singleton.CounterExample;

internal class Program
{
	private static void Main(string[] args)
	{
		#region Counter Example without using Singleton Pattern
		/*
		var Counter1 = new Counter();
		Counter1.AddOne();

		var Counter2 = new Counter();
		Counter2.AddOne();

		Console.WriteLine($"Counter 1 has Count : {Counter1.Count}");
		Console.WriteLine($"Counter 2 has Count : {Counter2.Count}"); 
		*/
		#endregion


		#region Counter Example after using Singleton Pattern + Lazy Initialization
		/*
		var Counter1 = Counter.GetInstance();
		var Counter2 = Counter.GetInstance();

		Counter1.AddOne();
		Console.WriteLine($"Counter 1 has Count : {Counter1.Count}");
		Console.WriteLine($"Counter 2 has Count : {Counter2.Count}");

		Console.WriteLine();

		Counter2.AddOne();
		Console.WriteLine($"Counter 1 has Count : {Counter1.Count}");
		Console.WriteLine($"Counter 2 has Count : {Counter2.Count}");
		*/
		#endregion


		Task t1 = Task.Factory.StartNew(() =>
		{
			var Counter1 = Counter.GetInstance();
			Counter1.AddOne();
			Console.WriteLine($"Counter 1 has Count : {Counter1.Count}");
		});

		Task t2 = Task.Factory.StartNew(() =>
		{

			var Counter2 = Counter.GetInstance();
			Counter2.AddOne();
			Console.WriteLine($"Counter 2 has Count : {Counter2.Count}");

		});

		Console.ReadKey();
	}
}