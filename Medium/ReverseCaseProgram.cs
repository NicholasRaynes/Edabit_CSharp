/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/99oN5igrbXddAjHEL
 */

using System;

namespace GitHubSandbox
{
	/// <summary>
	/// This class contains the declaration, implementation,
	/// and testing for the ReverseCase method.
	/// </summary>
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
		
		/// <summary>
		/// This method reverses the case of each character of a provided string. 
		/// All lower-cased letters should be upper-cased, and vice versa.
		/// </summary>
		/// <param name="input">The provided string to be scanned through.</param>
		/// <returns>A new string containing the characters of the original string reversed.</returns>
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
