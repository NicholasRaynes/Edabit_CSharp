using System;
using System.Linq;
using System.Collections.Generic;

namespace GitHubSandbox
{
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
