using System;
using System.Linq;

namespace AdventOfCode.Day10
{
    public class KnotHashSolver
    {
        public int CurrentPosition { get; set; }
        public int SkipSize { get; set; }
        public int[] ProblemSet { get; set; }

        public KnotHashSolver()
        {
            Reset();
        }

        public int[] Twist(int[] ints)
        {
            return ints.Reverse().ToArray();
        }

        public void TwistLength(int length)
        {
            var subArray = Twist(GetSubArray(length));
            var repositionIndex = CurrentPosition;
            foreach (var value in subArray)
            {
                ProblemSet[repositionIndex] = value;
                repositionIndex = (repositionIndex + 1) % ProblemSet.Length;
            }

            CurrentPosition += length + SkipSize;
            CurrentPosition = CurrentPosition % ProblemSet.Length;
            SkipSize++;
        }

        private int[] GetSubArray(int length)
        {
            var ret = ProblemSet.Skip(CurrentPosition).Take(length).ToArray();
            var amountToWrap = (CurrentPosition + length) - (ProblemSet.Length);
            if (amountToWrap > 0)
            {
                ret = ret.Concat(ProblemSet.Take(amountToWrap)).ToArray();
            }
            return ret;
        }

        public int Solve(string input)
        {
            foreach (var length in input.Split(new []{','},StringSplitOptions.RemoveEmptyEntries).Select(s=>Convert.ToInt32(s)))
            {
                TwistLength(length);
            }
            return ProblemSet[0] * ProblemSet[1];
        }

        public void Reset()
        {
            CurrentPosition = 0;
            SkipSize = 0;
            ProblemSet = new int[256];
            for (int i = 0; i < ProblemSet.Length; i++)
            {
                ProblemSet[i] = i;
            }
        }
    }
}