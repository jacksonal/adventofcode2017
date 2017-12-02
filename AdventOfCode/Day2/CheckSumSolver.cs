using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day2
{
    public abstract class CheckSumSolver
    {
        public abstract int GetRowCheckSum(IEnumerable<int> input);

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
                    ret += GetRowCheckSum(row);
                    line = sr.ReadLine();
                }
            }
            return ret;
        }
    }
}