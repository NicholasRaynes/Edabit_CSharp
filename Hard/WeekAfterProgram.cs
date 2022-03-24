/*
 * Name: Nicholas Raynes
 * Version: 0.0.1
 * Source: https://edabit.com/challenge/y4esBva2cYph5QKg5
 */

using System;
using System.Linq;
using System.Globalization;

namespace GitHubSandbox
{
    /// <summary>
    /// This class contains the declaration, implementation,
    /// and testing for the WeekAfter method.
    /// </summary>
    public class WeekAfterProgram
    {
        public static void Main(string[] args)
        {
            // Testing
            Console.WriteLine("Test #1 - WeekAfter('12/03/2020')\n{0}\n", WeekAfter("12/03/2020"));
            Console.WriteLine("Test #2 - WeekAfter('21/12/1989')\n{0}\n", WeekAfter("21/12/1989"));
            Console.WriteLine("Test #3 - WeekAfter('01/01/2000')\n{0}\n", WeekAfter("01/01/2000"));

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// This method takes in a date as a string, and returns the date a week after.
        /// </summary>
        /// <param name="date">The initial date.</param>
        /// <returns>The new date, a week after the initial date.</returns>
        public static string WeekAfter(string date)
        {
            DateTime d = new DateTime();

            d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            d = d.AddDays(7);

            return d.ToString("dd/MM/yyyy");
        }
    }
}
