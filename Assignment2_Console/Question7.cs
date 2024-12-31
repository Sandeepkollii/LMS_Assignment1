using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Console
{
    public class Question7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the maximum side of Triangle");
            int maxSide = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the minimum side of Triangle");
            int minSide = int.Parse(Console.ReadLine());

            
            int maxEdge = (maxSide + minSide) - 1;
            
            int minEdge = Math.Abs(maxSide - minSide) + 1;

            Console.WriteLine($"Maximum edge = {maxEdge}");
            Console.WriteLine($"Minimum edge = {minEdge}");
        }
    }
}
