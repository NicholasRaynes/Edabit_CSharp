using System;
using System.Linq;
using System.Collections.Generic;

namespace GitHubSandbox
{
    public class IsIsogramProgram
    {
        public static void Main(string[] args)
        {
            // Testing
            Console.WriteLine("Test #1 - IsIsogram('Algorism')\n{0}\n", IsIsogram("Algorism"));
            Console.WriteLine("Test #2 - IsIsogram('PasSword')\n{0}\n", IsIsogram("PasSword"));
            Console.WriteLine("Test #3 - IsIsogram('Consecutive')\n{0}\n", IsIsogram("Consecutive"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        public static bool IsIsogram(string input)
        {
            input = input.ToLower();

            List<char> clist = new List<char>();

            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (clist.Contains(input[i]))
                { 
                    return false; 
                }

                clist.Add(input[i]);
            }

            return true;
        }
    }
}
