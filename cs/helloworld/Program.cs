// See https://aka.ms/new-console-template for more information

namespace HelloWorld
{
	class Program 
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter name:");

			var name = Console.ReadLine();
			var today = DateTime.Now;

			Console.WriteLine($"\nHello {name}, on this day {today:d} @ {today:t}!");
			Console.Write("\n[press any key to exit]");
			Console.ReadKey(false);
		}
	}
}