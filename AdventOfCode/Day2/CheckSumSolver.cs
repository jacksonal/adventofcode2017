using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day2
{
    public class CheckSumSolver
    {
        public int GetLargestDifference(IEnumerable<int> input)
        {
            var sorted = input.ToList();
            sorted.Sort();
            return sorted.Last() - sorted.First();
        }

        public IEnumerable<int> ParseRow(string input)
        {
            var ret = new List<int>();
            foreach (var val in input.Split().Where(s => s != string.Empty))
            {
                ret.Add(Convert.ToInt32(val));
            }
            return ret;
        }

        public int Solve(string input)
        {
            var ret = 0;
            using (var sr = new StringReader(input))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    var row = ParseRow(line);
                    ret += GetLargestDifference(row);
                    line = sr.ReadLine();
                }
            }
            return ret;
        }
    }
}