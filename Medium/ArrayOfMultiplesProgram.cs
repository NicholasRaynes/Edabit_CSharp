using System;

namespace GitHubSandbox
{
    public class ArrayOfMultiplesProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test #1 - ArrayOfMultiples(7, 5)\n{0}\n", String.Join(", ", ArrayOfMultiples(7, 5)));
            Console.WriteLine("Test #2 - ArrayOfMultiples(12, 10)\n{0}\n", String.Join(", ", ArrayOfMultiples(12, 10)));
            Console.WriteLine("Test #3 - ArrayOfMultiples(17, 6)\n{0}\n", String.Join(", ", ArrayOfMultiples(17, 6)));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] multiples = new int[length];

            for (int i = 0; i < length; i++)
            {
                multiples[i] = num * (i + 1);
            }
            
            return multiples;
        }
    }
}
