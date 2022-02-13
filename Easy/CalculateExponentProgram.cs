using System;

namespace GitHubSandbox
{   
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
        
        public static long CalculateExponent(long baseNumber, long exponentNumber)
        {
            return (long)Math.Pow(baseNumber, exponentNumber);
        }
    }
}
