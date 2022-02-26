/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/hqTYj7NbLnCcjxryi
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// This class contains the declaration, implementation,
    /// and testing for the ParseArray method.
    /// </summary>
    public class ParseArrayProgram
    {
        static void Main(string[] args)
        {
            // Testing
            object[] test1 = { 1, 2, "a", "b" };
            object[] test2 = { "abc", 123, "def", 456 };
            object[] test3 = { 1, 2, 3, 17, 24, 3, "a", "123b" };

            Console.WriteLine("Test #1 - ParseArray([1, 2, 'a', 'b'])\n{0}\n", String.Join(", ", ParseArray(test1)));
            Console.WriteLine("Test #2 - ParseArray(['abc', 123, 'def', 456])\n{0}\n", String.Join(", ", ParseArray(test2)));
            Console.WriteLine("Test #3 - ParseArray([1, 2, 3, 17, 24, 3, 'a', '123b'])\n{0}\n", String.Join(", ", ParseArray(test3)));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// This method takes an array of integers and strings, converts integers to strings, and returns the array as a string array.
        /// </summary>
        /// <param name="arr">The provided array to be scanned through.</param>
        /// <returns>The new string array that consists of converted integers.</returns>
        public static string[] ParseArray(object[] arr)
        {
            string[] newArr = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                string str = arr[i] + " ";

                newArr[i] = str.Replace(" ", "");
            }

            return newArr;
        }
    }
}
