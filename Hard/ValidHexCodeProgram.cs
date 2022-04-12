using System;
using System.Linq;

namespace GitHubSandbox
{
    public class ValidHexCodeProgram
    {
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
