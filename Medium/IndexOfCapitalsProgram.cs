using System;
using System.Linq;
using System.Collections.Generic;

namespace GitHubSandbox
{
    public class IndexOfCapitalsProgram
    {
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
