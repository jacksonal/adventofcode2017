using System;
using System.Collections.Generic;

namespace AdventOfCode.Day16
{
    public class PartnerMove : DanceMove
    {
        public char Partner1 { get; set; }
        public char Partner2 { get; set; }

        public PartnerMove(string swaps)
        {
            var parts = swaps.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            Partner1 = parts[0][0];
            Partner2 = parts[1][0];
        }

        public override IList<char> Dance(IList<char> positions)
        {
            var p1Index = positions.IndexOf(Partner1);
            var p2Index = positions.IndexOf(Partner2);
            positions[p1Index] = Partner2;
            positions[p2Index] = Partner1;
            return positions;
        }
    }
}