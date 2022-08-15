using System;
using System.IO;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			string path = Environment.CurrentDirectory;

			List<string> dirs = new List<string>(Directory.EnumerateDirectories(path));

			foreach(var dd in dirs)
				Console.WriteLine($"{dd}");
		}
		catch(Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
