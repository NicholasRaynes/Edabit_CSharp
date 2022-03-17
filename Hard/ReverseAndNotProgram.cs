using System;

namespace GitHubSandbox
{
    public class ReverseAndNotProgram
    {
        public static string ReverseAndNot(int i)
        {
            string input = i.ToString();

            char[] arr = input.ToCharArray();

            Array.Reverse(arr);

            return new string(arr) + input;
        }
    }
}
