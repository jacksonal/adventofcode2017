using System;

namespace AdventOfCode.Day3
{
    public class ManhattenDistanceSpiralSolver
    {
        public int Solve(int startingPoint)
        {
            if (startingPoint == 1)
            {
                return 0;
            }
            var loc = GetLocation(startingPoint);
            //get distance from origin
            return Math.Abs(loc.X) + Math.Abs(loc.Y);
        }

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
            //Need to translate the grid so that the center is the origin.
            var dimensions = GetGridDimensions(squareNum) - 1;
            //start at the bottom right and determine which edge we're on.
            var edgeLoc = GetEdgeLocation(squareNum);
            var ret = new GridLocation(dimensions, dimensions);
            switch (edgeLoc.Edge)
            {
                case Edge.Bottom:
                    ret.Y = dimensions;
                    ret.X = dimensions - edgeLoc.Distance;
                    break;
                case Edge.Left:
                    ret.Y = dimensions - edgeLoc.Distance;
                    ret.X = 0;
                    break;
                case Edge.Top:
                    ret.X = dimensions - edgeLoc.Distance;
                    ret.Y = 0;
                    break;
                case Edge.Right:
                    ret.X = dimensions;
                    ret.Y = dimensions - edgeLoc.Distance;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            var translation = (int)Math.Floor(dimensions / 2.0);
            ret.X -= translation;
            ret.Y -= translation;
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
    }

    public enum Edge
    {
        Unknown = -1,
        Bottom = 0,
        Left = 1,
        Top = 2,
        Right = 3
    }

    public class EdgeLocation
    {
        public Edge Edge { get; set; }
        public int Distance { get; set; }
        
    }
    public class GridLocation
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GridLocation(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}