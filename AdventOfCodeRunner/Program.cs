using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode.Day1;
using AdventOfCode.Day2;

namespace AdventOfCodeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var day1Part1 = new ReverseCaptchaNextDuplicate();
            var day1Part2 = new ReverseCaptchaHalfwayAroundDuplicate();
            var day2Part1 = new BiggestDiffCheckSumSolver();
            var day2Part2 = new EvenlyDivisibleCheckSumSolver();
            Console.WriteLine($"day 1 solutions:");
            Console.WriteLine($"\tpart1:{day1Part1.Solve(Resources.Day1Input)}");
            Console.WriteLine($"\tpart2:{day1Part2.Solve(Resources.Day1Input)}");
            Console.WriteLine($"day 2 solutions:");
            Console.WriteLine($"\tpart1:{day2Part1.Solve(Resources.Day2Input)}");
            Console.WriteLine($"\tpart2:{day2Part2.Solve(Resources.Day2Input)}");
            Console.WriteLine("Happy Holidays!");
            Console.ReadLine();
        }
    }
}
