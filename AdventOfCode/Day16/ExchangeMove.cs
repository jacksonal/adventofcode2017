using System;
using System.Collections.Generic;

namespace AdventOfCode.Day16
{
    public class ExchangeMove : DanceMove
    {
        public int SwapPosA { get; set; }
        public int SwapPosB { get; set; }

        public ExchangeMove(string swaps)
        {
            var parts = swaps.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
            SwapPosA = Convert.ToInt32(parts[0]);
            SwapPosB = Convert.ToInt32(parts[1]);
        }

        public override IList<char> Dance(IList<char> positions)
        {
            var partner1 = positions[SwapPosA];
            var partner2 = positions[SwapPosB];
            positions[SwapPosA] = partner2;
            positions[SwapPosB] = partner1;
            return positions;
        }
    }
}