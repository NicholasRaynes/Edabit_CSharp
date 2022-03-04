using System;
using System.Linq;
using System.Collections.Generic;

namespace GitHubSandbox
{
    public class IsIsogramProgram
    {
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
