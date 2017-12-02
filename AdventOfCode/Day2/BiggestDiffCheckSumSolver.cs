using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day2
{
    public class BiggestDiffCheckSumSolver : CheckSumSolver
    {
        public override int GetRowCheckSum(IEnumerable<int> input)
        {
            var sorted = input.ToList();
            sorted.Sort();
            return sorted.Last() - sorted.First();
        }
    }
}