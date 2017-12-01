using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode.Day1;

namespace AdventOfCodeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var day1 = new ReverseCaptcha();
            Console.WriteLine($"day 1 solutions: {day1.Solve(Resources.Day1Input)}");
            Console.WriteLine("Happy Holidays!");
            Console.ReadLine();
        }
    }
}
