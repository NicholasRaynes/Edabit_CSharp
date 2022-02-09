/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/zhbYFanESDL3RfSyt
 */

using System;

namespace GitHubSandbox
{   
    /// <summary>
    /// This class contains the declaration, implementation,
    /// and testing for the IsIdentical method.
    /// </summary>
    class IsIdenticalProgram
    {
        public static void Main(string[] args)
        {
            // Testing
            string test1 = "aaaaaa";
            string test2 = "aabaaa";
            string test3 = "ccccca";
            string test4 = "kk";

            Console.WriteLine(IsIdentical(test1));
            Console.WriteLine(IsIdentical(test2));
            Console.WriteLine(IsIdentical(test3));
            Console.WriteLine(IsIdentical(test4));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// This method returns true if all characters in a 
        /// string are identical, and false otherwise.
        /// </summary>
        /// <param name="str">The string to be tested.</param>
        /// <returns>Whether or not all characters within the string
        /// are identical</returns>
        public static bool IsIdentical(string str)
        {
            char firstCharacter = str[0];

            for(int i = 0; i < str.Length; i++)
            {
                if(firstCharacter != str[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
