using System;
using System.Linq;
using System.Globalization;

namespace GitHubSandbox
{
    public class WeekAfterProgram
    {
        public static string WeekAfter(string date)
        {
            DateTime d = new DateTime();

            d = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            d = d.AddDays(7);

            return d.ToString("dd/MM/yyyy");
        }
    }
}
