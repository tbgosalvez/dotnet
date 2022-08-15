using UtilityLibraries;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter string:");
		
		string? inp = Console.ReadLine();
		
		if(string.IsNullOrEmpty(inp))
			return;

		Console.WriteLine("Begins with uppercase? " +
			$"{(inp.StartsWithUpper() ? "Yes" : "no")}\n");
	}
}