using System;

namespace GitHubSandbox
{
	public class ReverseCaseProgram
	{
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
