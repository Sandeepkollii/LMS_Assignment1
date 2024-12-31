using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Console
{
    public class Question6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of steps to print\n");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                
                for (int k = 0; k < 2; k++)
                {
                    
                    for (int j = 0; j < i * 2; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
