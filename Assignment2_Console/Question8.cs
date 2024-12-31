using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Console
{
    public class Question8
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int score = 0;

            while (true)
            {
                int num1 = random.Next(1, 11); 
                int num2 = random.Next(1, 11);

                Console.WriteLine($"What's {num1} times {num2}?");
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == num1 * num2)
                {
                    score++;
                    Console.WriteLine("That's the correct answer!");
                }
                else
                {
                    Console.WriteLine("Sorry, that's incorrect.");
                }

                Console.WriteLine($"Your score: {score}");

                Console.WriteLine("\nPress Enter to continue or type 'exit' to quit");
                if (Console.ReadLine().ToLower() == "exit")
                    break;
            }
        }
    }
}
