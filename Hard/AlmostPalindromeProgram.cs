/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/t6R99zCQ7nesR7Rdk
 */

using System;
using System.Linq;

namespace GitHubSandbox
{
    /// <summary>
    /// This class contains the declaration, implementation,
    /// and testing for the AlmostPalindrome method.
    /// </summary>
    public class AlmostPalindromeProgram
    {
        public static void Main(String[] args)
        {
            // Testing
            Console.WriteLine("Test #1 - AlmostPalindrome('abcdcbg')\n{0}\n", AlmostPalindrome("abcdcbg"));
            Console.WriteLine("Test #2 - AlmostPalindrome('abccia')\n{0}\n", AlmostPalindrome("abccia"));
            Console.WriteLine("Test #3 - AlmostPalindrome('abcdaaa')\n{0}\n", AlmostPalindrome("abcdaaa"));
            Console.WriteLine("Test #4 - AlmostPalindrome('1234312')\n{0}\n", AlmostPalindrome("1234312"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// A string is an almost-palindrome if, by changing only one character, you can make it a palindrome. 
        /// This method returns true if a string is an almost-palindrome and false otherwise.
        /// </summary>
        /// <param name="str">The provided string to be evaluated.</param>
        /// <returns>Whether or not a string is an almost-palindrome.</returns>
        public static bool AlmostPalindrome(string str)
        {
            int count = 0;

            string reversedStr = string.Join("", str.Reverse());

            for (int i = 0; i < str.Length; i++)
            {
                if (reversedStr[i] != str[i])
                {
                    count++;
                }
            }
             
            return count == 2;
        }
    }
}
