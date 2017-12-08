namespace AdventOfCode.Day8
{
    public abstract class Comparator
    {
        public static Comparator GetInstance(string symbol)
        {
            Comparator ret = null;
            switch (symbol)
            {
                case ">":
                    ret = new GreaterThanComparator();
                    break;
                case "<":
                    ret = new LessThanComparator();
                    break;
                case ">=":
                    ret = new GreaterThanOrEqualComparator();
                    break;
                case "<=":
                    ret = new LessThanOrEqualComparator();
                    break;
                case "==":
                    ret = new EqualComparator();
                    break;
            }
            return ret;
        }

        public abstract bool Compare(int left, int right);
    }
}