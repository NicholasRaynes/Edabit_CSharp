/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/esARjHfWfdRP6ePEC
 */

using System;

namespace GitHubSandbox
{   
    /// <summary>
    /// This class contains the declaration, implementation,
    /// and testing for the CalculateExponent method.
    /// </summary>
    public class CalculateExponentProgram
    {
        public static void Main(string[] args)
        {
            // Testing 
            Console.WriteLine("Test #1 - CalculateExponent(5, 5)\n{0}\n", CalculateExponent(5, 5));
            Console.WriteLine("Test #2 - CalculateExponent(10, 10)\n{0}\n", CalculateExponent(10, 10));
            Console.WriteLine("Test #3 - CalculateExponent(3, 6)\n{0}\n", CalculateExponent(3, 6));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// This method takes a base number and an exponent number and returns 
        /// the calculation.
        /// </summary>
        /// <param name="baseNumber">The base value for the calculation.</param>
        /// <param name="exponentNumber">The exponent value for the calculation.</param>
        /// <returns>The base value to the power of the exponent value.</returns>
        public static long CalculateExponent(long baseNumber, long exponentNumber)
        {
            return (long)Math.Pow(baseNumber, exponentNumber);
        }
    }
}
