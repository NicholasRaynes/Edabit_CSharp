using System;

namespace GitHubSandbox
{
	public class ReverseCaseProgram
	{
		public static void Main(string[] args)
		{
			// Testing
			Console.WriteLine("Test #1 - ReverseCase('Happy Birthday')\n{0}\n", ReverseCase("Happy Birthday"));
			Console.WriteLine("Test #2 - ReverseCase('MANY THANKS')\n{0}\n", ReverseCase("MANY THANKS"));
			Console.WriteLine("Test #3 - ReverseCase('sPoNtAnEoUs')\n{0}\n", ReverseCase("sPoNtAnEoUs"));

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
		
		public static string ReverseCase(string input)
		{
			string result = "";

			foreach (char element in input)
			{
				if (Char.IsUpper(element))
				{
					result += Char.ToLower(element);
				}
				else
				{
					result += Char.ToUpper(element);
				}
			}

			return result;
		}
	}
}
