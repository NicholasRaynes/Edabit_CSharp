using System;
using System.Linq;

namespace GitHubSandbox
{
    public class CountOnesProgram
    {
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
