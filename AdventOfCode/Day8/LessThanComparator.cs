namespace AdventOfCode.Day8
{
    public class LessThanComparator : Comparator
    {
        public override bool Compare(int left, int right)
        {
            return left < right;
        }
    }
}