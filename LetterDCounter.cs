/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/YxoGXwpApf9De7y5w
 */

using System;

namespace GitHubSandbox
{
    /// <summary>
    /// This program includes the declaration, implementation,
    /// and testing for the LetterDCounter method.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testing
            string test1 = "My friend Dylan got distracted in school.";
            string test2 = "Debris was scattered all over the yard.";
            string test3 = "The rodents hibernated in their den.";

            Console.WriteLine("Test #1 - 'My friend Dylan got distracted in school.'");
            Console.WriteLine("Expected: 4\nActual: {0}\n", LetterDCounter(test1));

            Console.WriteLine("Test #2 - 'Debris was scattered all over the yard.'");
            Console.WriteLine("Expected: 3\nActual: {0}\n", LetterDCounter(test2));

            Console.WriteLine("Test #3 - 'The rodents hibernated in their den.'");
            Console.WriteLine("Expected: 3\nActual: {0}\n", LetterDCounter(test3));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// This method counts and returns how often the letter 
        /// "d" occurs in a phrase, regardless of case.
        /// </summary>
        /// <param name="phrase">The phrase to be scanned for how many letter 
        /// d's it contains</param>
        /// <returns>Number of letter d's within the phrase.</returns>
        public static int LetterDCounter(string phrase)
        {
            int count = 0;

            for(int i = 0; i < phrase.Length; i++)
            {
                if(phrase[i] == 'd' || phrase[i] == 'D')
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}
