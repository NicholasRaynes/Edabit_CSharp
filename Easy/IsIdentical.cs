using System;

namespace GitHubSandbox
{   
    internal class Program
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
