using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Console
{
    public class Question5
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime yesterday = today.AddDays(-1);
            DateTime tomorrow = today.AddDays(1);

            Console.WriteLine("Today's Date:");
            Console.WriteLine(today.ToString("MM/dd/yyyy hh:mm:ss tt"));

            Console.WriteLine("Tomorrow's Date:");
            Console.WriteLine(tomorrow.ToString("MM/dd/yyyy hh:mm:ss tt"));

            Console.WriteLine("Yesterday's Date:");
            Console.WriteLine(yesterday.ToString("MM/dd/yyyy hh:mm:ss tt"));
        }
    }
}
