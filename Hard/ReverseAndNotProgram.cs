/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/YGhgctqPsKQxQQCFS
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// This class contains the declaration, implementation,
    /// and testing for the ReverseAndNot method.
    /// </summary>
    public class ReverseAndNotProgram
    {
        public static void Main(string[] args)
        {
            // Testing
            Console.WriteLine("Test #1 - ReverseAndNot(123)\n{0}\n", ReverseAndNot(123));
            Console.WriteLine("Test #2 - ReverseAndNot(152)\n{0}\n", ReverseAndNot(152));
            Console.WriteLine("Test #3 - ReverseAndNot(123456789)\n{0}\n", ReverseAndNot(123456789));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// This method takes an integer i and returns a string with the integer backwards followed 
        /// by the original integer.
        /// </summary>
        /// <param name="i">The provided integer.</param>
        /// <returns>A string container the integer reversed, followed by the original integer.</returns>
        public static string ReverseAndNot(int i)
        {
            string input = i.ToString();

            char[] arr = input.ToCharArray();

            Array.Reverse(arr);

            return new string(arr) + input;
        }
    }
}
