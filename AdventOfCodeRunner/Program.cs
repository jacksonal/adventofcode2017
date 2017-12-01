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
            var day1Part1 = new ReverseCaptchaNextDuplicate();
            var day1Part2 = new ReverseCaptchaHalfwayAroundDuplicate();
            Console.WriteLine($"day 1 solutions: part1:{day1Part1.Solve(Resources.Day1Input)}");
            Console.WriteLine($"\tpart1:{day1Part1.Solve(Resources.Day1Input)}");
            Console.WriteLine($"\tpart2:{day1Part2.Solve(Resources.Day1Input)}");
            Console.WriteLine("Happy Holidays!");
            Console.ReadLine();
        }
    }
}
