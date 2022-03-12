using System;
using System.Linq;

namespace GitHubSandbox
{
    /// <summary>
    /// This class contains the declaration, implementation,
    /// and testing for the CountOnes method.
    /// </summary>
    public class CountOnesProgram
    {
	public static void Main(string[] args)
	{
		// Testing
		Console.WriteLine("Test #1 - CountOnes(0)\n{0}\n", CountOnes(0));
		Console.WriteLine("Test #2 - CountOnes(100)\n{0}\n", CountOnes(100));
		Console.WriteLine("Test #3 - CountOnes(999)\n{0}\n", CountOnes(999));

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
	    
	/// <summary>
	/// This method counts the amount of ones in the provided binary 
	/// representation of an integer.
	/// </summary>
	/// <param name="i">The provided binary representation of an integer.</param>
	/// <returns></returns>
	public static int CountOnes(int i)
	{
		string binary = Convert.ToString(i, 2);

		int count = 0;

		foreach (char c in binary)
		{
			if (c == '1')
			{
				count++;
			}
		}
			
		return count;
		}
	}
}
