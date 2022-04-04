using System;

namespace GitHubSandbox
{
    public class NextPrimeProgram
    {
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
