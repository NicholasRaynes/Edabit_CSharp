/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/2QvnWexKoLfcJkSsc
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// This class contains the declaration, implementation,
    /// and testing for the ArrayOfMultiples method.
    /// </summary>
    public class ArrayOfMultiplesProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test #1 - ArrayOfMultiples(7, 5)\n{0}\n", String.Join(", ", ArrayOfMultiples(7, 5)));
            Console.WriteLine("Test #2 - ArrayOfMultiples(12, 10)\n{0}\n", String.Join(", ", ArrayOfMultiples(12, 10)));
            Console.WriteLine("Test #3 - ArrayOfMultiples(17, 6)\n{0}\n", String.Join(", ", ArrayOfMultiples(17, 6)));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Create a function that takes two numbers as arguments (num, length) and returns an array of 
        /// multiples of num until the array length reaches length.
        /// </summary>
        /// <param name="num">The number to find multiples of.</param>
        /// <param name="length">The limit to how many multiples are generated.</param>
        /// <returns>An array of multiples of the integer provided, up to length times.</returns>
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] multiples = new int[length];

            for (int i = 0; i < length; i++)
            {
                multiples[i] = num * (i + 1);
            }
            
            return multiples;
        }
    }
}
