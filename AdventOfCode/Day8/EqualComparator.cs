namespace AdventOfCode.Day8
{
    public class EqualComparator : Comparator
    {
        public override bool Compare(int left, int right)
        {
            return left == right;
        }
    }
}