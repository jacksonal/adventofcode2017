using System;

namespace AdventOfCode.Day3
{
    public class AccumulatingAdjacentSpiralSolver: SpiralSolver
    {

        public int GetSquareValue(int squareNum)
        {
            var ret = 0;
            if (squareNum == 1)
            {
                ret = 1;
            }
            else
            {
                var checkSquare = squareNum;
                while (checkSquare > 1)
                {
                    if (IsAdjacent(squareNum, --checkSquare))
                    {
                        ret += GetSquareValue(checkSquare);
                    }
                }
            }
            return ret;
        }

        public override int Solve(int input)
        {
            return RecursiveSolve(1,input);
        }

        /// <summary>
        /// recursively find the first value larger than the input given.
        /// </summary>
        /// <param name="squareNum"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        private int RecursiveSolve(int squareNum, int input)
        {
            var value = GetSquareValue(squareNum);
            if (value > input)
            {
                return value;
            }
            else
            {
                return RecursiveSolve(squareNum + 1, input);
            }
        }

        private bool IsAdjacent(int squareA, int squareB)
        {
            var locA = GetLocation(squareA);
            var locB = GetLocation(squareB);

            if (locA.X == locB.X || locA.Y == locB.Y)
            {
                return GetDistance(locA, locB) == 1;
            }
            else
            {
                return GetDistance(locA, locB) == 2;
            }
        }
    }
}