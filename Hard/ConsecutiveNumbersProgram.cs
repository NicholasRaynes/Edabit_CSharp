using System;

namespace GitHubSandbox
{
  public class ConsecutiveNumbersProgram
  {
    public static bool ConsecutiveNumbers(int[] arr)
    {
      Array.Sort(arr);
      
      for (int i = 0; i < arr.Length - 1; i++)
      {
      	if (arr[i] + 1 != arr[i + 1])
	{
	  return false;
	}
      }
      
      return true;
    }
  }
}
