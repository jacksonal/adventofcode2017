namespace AdventOfCode.Day8
{
    public class Decrementor : Operator
    {
        public override int Operate(int left, int right)
        {
            return left - right;
        }
    }
}