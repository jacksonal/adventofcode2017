using System;

namespace AdventOfCode.Day3
{
    public class ManhattenDistanceSpiralSolver : SpiralSolver
    {
        public override int Solve(int startingPoint)
        {
            if (startingPoint == 1)
            {
                return 0;
            }
            var loc = GetLocation(startingPoint);
            //get distance from origin
            return GetDistance(loc, new GridLocation(0,0));
        }
    }
}