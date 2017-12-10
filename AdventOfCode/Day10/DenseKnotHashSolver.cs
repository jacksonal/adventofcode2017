using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day10
{
    public class DenseKnotHashSolver : KnotHashSolver
    {
        public string GetDenseHash(string input)
        {
            var toAscii = new List<int>();
            foreach (char c in input)
            {
                toAscii.Add(c);
            }
            //Extra values added to all input:
            toAscii.AddRange(new List<int>{17,31,73,47,23});

            //run 64 times
            for (int i = 0; i < 64; i++)
            {
                Solve(toAscii);
            }
            var hash = CreateDenseHash();
            return string.Join("",hash.Select(h=>h.ToString("X2"))).ToLower();
        }

        public int[] CreateDenseHash()
        {
            var ret = new int[16];
            for (int i = 0; i < 16; i++)
            {
                var set = ProblemSet.Skip(i * 16).Take(16).ToArray();
                if (set.Any())
                {
                    ret[i] = set.Skip(1).Aggregate(set.First(), ((i1, i2) => i1 ^ i2));
                }
            }
            return ret;
        }

        private void Solve(List<int> toAscii)
        {
            foreach (var length in toAscii)
            {
                TwistLength(length);
            }
        }
    }
}