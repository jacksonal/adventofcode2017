using System;
using System.Collections.Generic;

namespace AdventOfCode.Day16
{
    public class SpinMove : DanceMove
    {
        public int SpinCount { get; set; }

        public SpinMove(string spinCount)
        {
            SpinCount = Convert.ToInt32(spinCount);
        }

        public override List<char> Dance(IList<char> positions)
        {
            var ret = new List<char>(positions);
            for (int i = 0; i < positions.Count; i++)
            {
                ret[(i + SpinCount) % positions.Count] = positions[i];
            }
            return ret;
        }
    }
}