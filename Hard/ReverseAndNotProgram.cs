using System;

namespace GitHubSandbox
{
    public class ReverseAndNotProgram
    {
        public static void Main(string[] args)
        {
            // Testing
            Console.WriteLine("Test #1 - ReverseAndNot(123)\n{0}\n", ReverseAndNot(123));
            Console.WriteLine("Test #2 - ReverseAndNot(152)\n{0}\n", ReverseAndNot(152));
            Console.WriteLine("Test #3 - ReverseAndNot(123456789)\n{0}\n", ReverseAndNot(123456789));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        public static string ReverseAndNot(int i)
        {
            string input = i.ToString();

            char[] arr = input.ToCharArray();

            Array.Reverse(arr);

            return new string(arr) + input;
        }
    }
}
