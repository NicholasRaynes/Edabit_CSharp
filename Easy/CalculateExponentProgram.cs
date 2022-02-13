using System;

namespace GitHubSandbox
{   
    public class CalculateExponentProgram
    {
        public static long CalculateExponent(long baseNumber, long exponentNumber)
        {
            return (long)Math.Pow(baseNumber, exponentNumber);
        }
    }
}
