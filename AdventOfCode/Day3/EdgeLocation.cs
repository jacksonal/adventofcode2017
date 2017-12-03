namespace AdventOfCode.Day3
{
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
}