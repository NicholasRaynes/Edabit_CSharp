using System;
using System.Linq;

namespace GitHubSandbox
{
    public class ValidHexCodeProgram
    {
	public static void Main(string[] args)
        {
		// Testing
		Console.WriteLine("Test #1 - ValidHexCode('#CD5C5C')\n{0}\n", ValidHexCode("#CD5C5C"));
		Console.WriteLine("Test #2 - ValidHexCode('#CD5C58C')\n{0}\n", ValidHexCode("#CD5C58C"));
		Console.WriteLine("Test #3 - ValidHexCode('CD5C5C')\n{0}\n", ValidHexCode("CD5C5C"));

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	} 
	
	/// <summary>
	/// This method determines whether a string is a valid hex code.
	/// </summary>
	/// <param name="str">The provided string to be evaluated.</param>
	/// <returns>Whether or not the provided string is a valid hex code.</returns>
    	public static bool ValidHexCode(string str)
	{
		string alpha = "#abcdef0123456789";

		str = str.ToLower();

		if (str.Length != 7 || str[0] != '#')
		{
			return false;
		}

		foreach (char c in str)
		{
			if (!alpha.Contains(c))
			{
				return false;
			}
		}
        
		return true;
		}
	}
}
