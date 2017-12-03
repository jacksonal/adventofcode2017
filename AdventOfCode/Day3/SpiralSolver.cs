using System;

namespace AdventOfCode.Day3
{
    public abstract class SpiralSolver
    {
        public abstract int Solve(int startingPoint);

        public int GetGridDimensions(int squareNum)
        {
            var gridDimensions = (int) Math.Ceiling(Math.Sqrt(squareNum));
            return gridDimensions % 2 == 0 ? gridDimensions + 1 : gridDimensions;
        }

        /// <summary>
        /// Get the location on the coordinate plane of the given square.
        /// </summary>
        /// <param name="squareNum"></param>
        /// <returns></returns>
        public GridLocation GetLocation(int squareNum)
        {
            var ret = new GridLocation(0,0);
            if (squareNum != 1)
            {
                //Need to translate the grid so that the center is the origin.
                var maxCoord = GetGridDimensions(squareNum) - 1;
                //start at the bottom right and determine which edge we're on.
                var edgeLoc = GetEdgeLocation(squareNum);
                ret = new GridLocation(maxCoord, maxCoord);
                switch (edgeLoc.Edge)
                {
                    case Edge.Bottom:
                        ret.Y = 0;
                        ret.X = maxCoord - edgeLoc.Distance;
                        break;
                    case Edge.Left:
                        ret.Y = edgeLoc.Distance;
                        ret.X = 0;
                        break;
                    case Edge.Top:
                        ret.X = edgeLoc.Distance;
                        ret.Y = maxCoord;
                        break;
                    case Edge.Right:
                        ret.X = maxCoord;
                        ret.Y = maxCoord - edgeLoc.Distance;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                var translation = (int) Math.Floor(maxCoord / 2.0);
                ret.X -= translation;
                ret.Y -= translation;
            }
            return ret;
        }

        public EdgeLocation GetEdgeLocation(int squareNum)
        {
            var ret = new EdgeLocation{Edge = Edge.Unknown};
            var dimensions = GetGridDimensions(squareNum);
            //start at the bottom right and determine which edge we're on.
            var start = dimensions * dimensions;
            var stepsToCorner = dimensions - 1;
            while (start >= squareNum)
            {
                ret.Distance = start - squareNum;
                start -= stepsToCorner;
                ret.Edge++;
            }
            
            return ret;
        }

        protected int GetDistance(GridLocation locA, GridLocation locB)
        {
            return Math.Abs(locA.X - locB.X) + Math.Abs(locA.Y - locB.Y);
        }
    }
}