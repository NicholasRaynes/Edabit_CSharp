using System;

namespace GitHubSandbox
{   
    internal class Program
    {
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
