using System;

namespace AdventOfCode.Day11
{
    public class MaxDistanceHexPathSolver : HexPathSolver
    {
        private int _maxDistance;
        public override void Step(string direction)
        {
            base.Step(direction);
            _maxDistance = Math.Max(_maxDistance, GetDistanceFromOrigin());
        }

        public override int Solve(string input)
        {
            TravelThePath(input);
            return _maxDistance;
        }
    }
}