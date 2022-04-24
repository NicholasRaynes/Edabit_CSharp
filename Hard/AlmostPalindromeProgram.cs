using System;
using System.Linq;

namespace GitHubSandbox
{
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
