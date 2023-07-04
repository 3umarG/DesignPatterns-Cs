using Creational.AbstractFactory.Concretes.Factories;
using Creational.AbstractFactory.Interfaces;
using Creational.Builder;
using Creational.Factory.Clients;
using Creational.Factory.Concretes;
using Creational.Factory.Interfaces;
using Creational.Prototype;
using Creational.Singleton.CounterExample;

internal class Program
{

	private static void Main(string[] args)
	{
		#region Singleton Design Pattern

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

		#region Singleton with/without using Lock Thread Safety
		/*
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
		*/
		#endregion

		#endregion

		#region Protoype Design Pattern
		/*
		EmployeePrototype employee = new TempEmployee
		{
			ID = 1,
			Name = "Omar",
			EmpAddress = new Address
			{
				Country = "Egypt",
				City = "Gharbia",
				Street = "55"
			}
		};


		//EmployeePrototype employeeCopy = employee.ShallowClone();
		EmployeePrototype employeeCopy = employee.DeepClone();
		Console.WriteLine("========== Shallow Clone ==========");

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("========== The base Object ==========");
		Console.WriteLine(employee.ToString());

		Console.WriteLine("========== The Cloned Object ==========");
		Console.WriteLine(employeeCopy.ToString());

		employeeCopy.EmpAddress.Country = "Kuwait";
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("========== The base Object after changed ==========");
		Console.WriteLine(employee.ToString());

		Console.WriteLine("========== The Cloned Object after changed ==========");
		Console.WriteLine(employeeCopy.ToString());
		*/
		#endregion

		#region Builder Design Pattern
		/*
		// The type of product that the client need .
		IBuilder house = new HouseBuilder();
		IBuilder villa = new HouseBuilder();

		// The Director that deals with the builder to construct the specific object .
		var directorForHouse = new Director(house);
		var directorForVilla = new Director(villa);

		// The Build Order
		directorForHouse.Build1();
		directorForVilla.Build2();

        // now !! My builder object has been filled of all its fields and properties without need to construct it by myself
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("========== The House Object ==========");
		Console.ForegroundColor = ConsoleColor.Magenta;
		Console.WriteLine(house.ToString());

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("========== The Villa Object ==========");
		Console.ForegroundColor = ConsoleColor.Magenta;
		Console.WriteLine(villa.ToString());


		Console.ForegroundColor = ConsoleColor.White;

		/// Finally I can make alot and more more ... Builder Objects that may have heavy and complex construction 
		/// very easy by talk to Director and give it the requirements

		/// **************************** It is the Buildler Pattern ****************************
		*/
		#endregion

		#region Factory Method Design Pattern

		/*
		 * Any Banks you want to add , you must add only new factory to it and implement 
		 * IBankFactory for factoris , IBank for banks classes 
		 * 
		 * and wallah !!! you generate Factory Method Pattern
		 */

		/*
		Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("================== Factory Method Pattern ==================");
		Console.WriteLine();
		Console.WriteLine();

		Console.ForegroundColor= ConsoleColor.Magenta;
		IBankFactory bankAFactory = new BankAFactory();
		IBank bankA = bankAFactory.FactoryMethod();
        Console.WriteLine(BankClient.Draw(bankA , 566.5));

        Console.WriteLine();
		
		Console.ForegroundColor = ConsoleColor.Blue;
		IBankFactory bankBFactory = new BankBFactory();
		IBank bankB = bankBFactory.FactoryMethod();
		Console.WriteLine(BankClient.Draw(bankB, 566.5));

		*/
		#endregion


		#region Abstract Factory Pattern
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("================== Abstarct Factory Pattern ==================");
		Console.WriteLine();
		Console.WriteLine();

		Console.ForegroundColor = ConsoleColor.Magenta;
		IFurnitureFactory basicFurnitureFactory = new BasicFurnitureFactory();

		/// all objects that BasicFurnitureFactory will return will be same in Basic , all have shared .
		var basicFurnitures = new List<IFurniture>();
		IChair basicChair = basicFurnitureFactory.CreateChair();
		ISofa basicSofa = basicFurnitureFactory.CreateSofa();
		ITable basicTable = basicFurnitureFactory.CreateTable();

		basicFurnitures.AddRange(new List<IFurniture> { basicChair, basicSofa, basicTable });
		basicFurnitures.ForEach(F => Console.WriteLine(F.GetModel()));

		Console.WriteLine();


		Console.ForegroundColor = ConsoleColor.Blue;
		IFurnitureFactory modernFurnitureFactory = new ModernFurnitureFactory();

		/// all objects that BasicFurnitureFactory will return will be same in Basic , all have shared .
		var modernFurnitures = new List<IFurniture>();
		IChair modernChair = modernFurnitureFactory.CreateChair();
		ISofa modernSofa = modernFurnitureFactory.CreateSofa();
		ITable modernTable = modernFurnitureFactory.CreateTable();

		modernFurnitures.AddRange(new List<IFurniture> { modernChair, modernSofa, modernTable });
		modernFurnitures.ForEach(F => Console.WriteLine(F.GetModel()));

		Console.WriteLine();


		#endregion
		Console.ReadKey();
	}

}