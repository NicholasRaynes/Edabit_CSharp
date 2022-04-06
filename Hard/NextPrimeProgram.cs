using System;

namespace GitHubSandbox
{
    /// <summary>
    /// This class contains the declaration, implementation,
    /// and testing for the NextPrime method.
    /// </summary>
    public class NextPrimeProgram
    {
        public static void Main(String[] args)
        {
            // Testing
            Console.WriteLine("Test #1 - NextPrime(12)\n{0}\n", NextPrime(12));
            Console.WriteLine("Test #2 - NextPrime(24)\n{0}\n", NextPrime(24));
            Console.WriteLine("Test #3 - NextPrime(11)\n{0}\n", NextPrime(11));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Given an integer, this method returns the next prime. If the number is prime, 
        /// return the number itself.
        /// </summary>
        /// <param name="num">The provided integer.</param>
        /// <returns>The next prime, unless the number is a prime, then return the number itself.</returns>
        public static int NextPrime(int num)
        {
            int result = 1;

            for (int i = 1; i <= num; i++)
            {
                if ((num % i == 0) && (i != num) && (i != 1))
                {
                    i = 0;

                    num++;
                }
                else if ((num % i == 0) && (i == num))
                {
                    result = i;
                }
            }

            return result;
        }
    }
}
