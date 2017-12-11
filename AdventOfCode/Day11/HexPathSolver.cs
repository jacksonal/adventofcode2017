using System;

namespace AdventOfCode.Day11
{
    public class HexPathSolver
    {
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
        public int CurrentZ { get; set; }

        public virtual void Step(string direction)
        {
            switch (direction)
            {
                case "n":
                    CurrentY++;
                    CurrentZ--;
                    break;
                case "s":
                    CurrentY--;
                    CurrentZ++;
                    break;
                case "ne":
                    CurrentX++;
                    CurrentZ--;
                    break;
                case "se":
                    CurrentX++;
                    CurrentY--;
                    break;
                case "nw":
                    CurrentX--;
                    CurrentY++;
                    break;
                case "sw":
                    CurrentX--;
                    CurrentZ++;
                    break;
            }
        }

        public virtual int Solve(string input)
        {
            TravelThePath(input);
            return GetDistanceFromOrigin();
        }

        protected void TravelThePath(string input)
        {
            foreach (var dir in input.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries))
            {
                Step(dir);
            }
        }

        protected int GetDistanceFromOrigin()
        {
            return (Math.Abs(CurrentX) + Math.Abs(CurrentY) + Math.Abs(CurrentZ)) / 2;
        }
    }
}