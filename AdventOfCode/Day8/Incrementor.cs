namespace AdventOfCode.Day8
{
    public class Incrementor : Operator
    {
        public override int Operate(int left, int right)
        {
            return left + right;
        }
    }
}