namespace AdventOfCode.Day8
{
    public class Statement
    {
        public Operator Operator { get; set; }
        public Comparator Comparator { get; set; }
        public int OperateLeft { get; set; }
        public int OperateRight { get; set; }
        public int CompareLeft { get; set; }
        public int CompareRight { get; set; }

        public int Evaluate()
        {
            return Comparator.Compare(CompareLeft, CompareRight)
                ? Operator.Operate(OperateLeft, OperateRight)
                : OperateLeft;
        }
    }
}