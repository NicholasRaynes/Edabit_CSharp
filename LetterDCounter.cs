using System;

namespace GitHubSandbox
{
    internal class Program
    {
        public static int LetterDCounter(string phrase)
        {
            int count = 0;

            for(int i = 0; i < phrase.Length; i++)
            {
                if(phrase[i] == 'd' || phrase[i] == 'D')
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}
