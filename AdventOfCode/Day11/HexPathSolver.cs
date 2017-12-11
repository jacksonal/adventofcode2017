namespace AdventOfCode.Day11
{
    public class HexPathSolver
    {
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
        public int CurrentZ { get; set; }

        public void Step(string direction)
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
    }
}