using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day2
{
    public class EvenlyDivisibleCheckSumSolver : CheckSumSolver
    {
        public override int GetRowCheckSum(IEnumerable<int> input)
        {
            var ret = 0;
            var sorted = input.ToList();
            //sort and reverse. reduces the problem space. We only need to check starting with numbers smaller than 1/2 the number we are checking.
            sorted.Sort();
            sorted.Reverse();

            for (int i = 0; i < sorted.Count; i++)
            {
                var num = sorted[i];
                for (int j = i + 1; j < sorted.Count; j++)
                {
                    var divisor = sorted[j];
                    if (num % divisor == 0)
                    {
                        ret = num / divisor;
                    }
                }
            }
            return ret;
        }
    }
}