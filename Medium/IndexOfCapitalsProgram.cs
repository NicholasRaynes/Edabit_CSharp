/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/6qFnpAhd3kdmYcNG2
 */

using System;
using System.Collections.Generic;

namespace GitHubSandbox
{
    /// <summary>
    /// This class contains the declaration, implementation,
    /// and testing for the IndexOfCapitals method.
    /// </summary>
    public class IndexOfCapitalsProgram
    {
	public static void Main(string[] args)
        {
		// Testing
		Console.WriteLine("Test #1 - IndexOfCapitals('eDaBiT')\n{0}\n", String.Join(", ", IndexOfCapitals("eDaBiT")));
		Console.WriteLine("Test #2 - IndexOfCapitals('eQuINoX')\n{0}\n", String.Join(", ", IndexOfCapitals("eQuINoX")));
		Console.WriteLine("Test #3 - IndexOfCapitals('determine')\n{0}\n", String.Join(", ", IndexOfCapitals("determine")));
		Console.WriteLine("Test #4 - IndexOfCapitals('STRIKE')\n{0}\n", String.Join(", ", IndexOfCapitals("STRIKE")));
		Console.WriteLine("Test #5 - IndexOfCapitals('sUn')\n{0}\n", String.Join(", ", IndexOfCapitals("sUn")));

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}

	/// <summary>
        /// This method takes a single string as argument and returns an ordered array containing 
	/// the indices of all the capital letters in the string.
	/// </summary>
	/// <param name="input">The string to be scanned through for capital letters.</param>
	/// <returns>An array containing all the capital letters within the input string.</returns>
	public static int[] IndexOfCapitals(string input)
	{
		string lowerString = input.ToLower();

		char[] arr = input.ToCharArray();

		List<int> indexList = new List<int>();

		for (int i = 0; i < arr.Length; i++)
		{
			if (arr[i] != lowerString[i])
			{
				indexList.Add(i);
			}
		}
		
		return indexList.ToArray();
	}	
    }    
}
