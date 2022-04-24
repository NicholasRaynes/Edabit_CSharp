using System;
using System.Linq;

namespace GitHubSandbox
{
    public class AlmostPalindromeProgram
    {
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
