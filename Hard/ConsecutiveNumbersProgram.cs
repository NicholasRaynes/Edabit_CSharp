using System;

namespace GitHubSandbox
{
  public class ConsecutiveNumbersProgram
  {
    public static void Main(string[] args)
    {
    	int[] test1 = { 5, 1, 4, 3, 2 };
	int[] test2 = { 5, 1, 4, 3, 2, 8 };
	int[] test3 = { 5, 6, 7, 8, 9, 9 };

	// Testing
	Console.WriteLine("Test #1 - ConsecutiveNumbers([5, 1, 4, 3, 2])\n{0}\n", ConsecutiveNumbers(test1));
	Console.WriteLine("Test #2 - ConsecutiveNumbers([5, 1, 4, 3, 2, 8])\n{0}\n", ConsecutiveNumbers(test2));
	Console.WriteLine("Test #3 - ConsecutiveNumbers([5, 6, 7, 8, 9, 9])\n{0}\n", ConsecutiveNumbers(test3));

	Console.WriteLine("Press any key to exit...");
	Console.ReadKey();
    } 
    
    /// <summary>
    /// This method determines whether elements in an array can be re-arranged to form a consecutive list of 
    /// numbers where each number appears exactly once.
    /// </summary>
    /// <param name="arr">The provided array to be evaluated.</param>
    /// <returns>Wether or not the provided array can be re-arranged to form a consecutive list
    /// of numbers where each number appears exactly once.</returns>
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
