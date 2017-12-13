using System;
using AdventOfCode.Day1;
using AdventOfCode.Day10;
using AdventOfCode.Day11;
using AdventOfCode.Day12;
using AdventOfCode.Day13;
using AdventOfCode.Day2;
using AdventOfCode.Day3;
using AdventOfCode.Day4;
using AdventOfCode.Day5;
using AdventOfCode.Day6;
using AdventOfCode.Day7;
using AdventOfCode.Day8;
using AdventOfCode.Day9;

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
            var day3Part1 = new ManhattenDistanceSpiralSolver();
            var day3Part2 = new AccumulatingAdjacentSpiralSolver();
            var day4Part1 = new UniquePassphraseValidator();
            var day4Part2 = new UniqueAnagramPassphraseValidator();
            var day5Part1 = new JumpMazeSolver(Resources.Day5Input);
            var day5Part2 = new StrangerJumpMazeSolver(Resources.Day5Input);
            var day6Part1 = new MemoryReallocationSolver(Resources.Day6Input);
            var day6Part2 = new MemoryReallocationLoopSizeSolver(Resources.Day6Input);
            var day7Part1 = new ProgramTreeRootSolver();
            var day7Part2 = new ProgramTreeBalanceSolver();
            var day8Part1 = new RegisterInstructionsSolver();
            var day8Part2 = new RegisterInstructionsMaxEverSolver();
            var day9Part1 = new NestedStreamSolver();
            var day9Part2 = new NestedStreamTrashCountSolver();
            var day10Part1 = new KnotHashSolver();
            var day10Part2 = new DenseKnotHashSolver();
            var day11Part1 = new HexPathSolver();
            var day11Part2 = new MaxDistanceHexPathSolver();
            var day12Part1 = new ProgramGraphBuilder().BuildGraph(Resources.Day12Input);
            
            //day13
            var securityModel = SecurityScanner.CreateModel(Resources.Day13Input);
            var day13Part1 = new SecurityScannerTraveller(securityModel);

            Console.WriteLine($"day 1 solutions:");
            Console.WriteLine($"\tpart1:{day1Part1.Solve(Resources.Day1Input)}");
            Console.WriteLine($"\tpart2:{day1Part2.Solve(Resources.Day1Input)}");

            Console.WriteLine($"day 2 solutions:");
            Console.WriteLine($"\tpart1:{day2Part1.Solve(Resources.Day2Input)}");
            Console.WriteLine($"\tpart2:{day2Part2.Solve(Resources.Day2Input)}");

            Console.WriteLine($"day 3 solutions:");
            Console.WriteLine($"\tpart1:{day3Part1.Solve(277678)}");
            Console.WriteLine($"\tpart2:{day3Part2.Solve(277678)}");

            Console.WriteLine($"day 4 solutions:");
            Console.WriteLine($"\tpart1:{day4Part1.Solve(Resources.Day4Input)}");
            Console.WriteLine($"\tpart2:{day4Part2.Solve(Resources.Day4Input)}");

            Console.WriteLine($"day 5 solutions:");
            Console.WriteLine($"\tpart1:{day5Part1.Solve()}");
            Console.WriteLine($"\tpart2:{day5Part2.Solve()}");

            Console.WriteLine($"day 6 solutions:");
            Console.WriteLine($"\tpart1:{day6Part1.Solve()}");
            Console.WriteLine($"\tpart2:{day6Part2.Solve()}");

            Console.WriteLine($"day 7 solutions:");
            Console.WriteLine($"\tpart1:{day7Part1.Solve(Resources.Day7Input)}");
            Console.WriteLine($"\tpart2:{day7Part2.Solve(Resources.Day7Input)}");

            Console.WriteLine($"day 8 solutions:");
            Console.WriteLine($"\tpart1:{day8Part1.Solve(Resources.Day8Input)}");
            Console.WriteLine($"\tpart2:{day8Part2.Solve(Resources.Day8Input)}");

            Console.WriteLine($"day 9 solutions:");
            Console.WriteLine($"\tpart1:{day9Part1.Solve(Resources.Day9Input)}");
            Console.WriteLine($"\tpart2:{day9Part2.Solve(Resources.Day9Input)}");

            Console.WriteLine($"day 10 solutions:");
            Console.WriteLine($"\tpart1:{day10Part1.Solve(Resources.Day10Input)}");
            Console.WriteLine($"\tpart2:{day10Part2.GetDenseHash(Resources.Day10Input)}");

            Console.WriteLine($"day 11 solutions:");
            Console.WriteLine($"\tpart1:{day11Part1.Solve(Resources.Day11Input)}");
            Console.WriteLine($"\tpart2:{day11Part2.Solve(Resources.Day11Input)}");

            Console.WriteLine($"day 12 solutions:");
            Console.WriteLine($"\tpart1:{day12Part1.CountNodes(0)}");
            Console.WriteLine($"\tpart2:{day12Part1.CountGroups()}");

            Console.WriteLine($"day 13 solutions:");
            Console.WriteLine($"\tpart1:{day13Part1.MoveToEnd()}");

            Console.WriteLine("Happy Holidays!");
            Console.ReadLine();
        }
    }
}
