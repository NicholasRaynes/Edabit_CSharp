/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/kMWmiNJM4szSv7dLd
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
