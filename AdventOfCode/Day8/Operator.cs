namespace AdventOfCode.Day8
{
    public abstract class Operator
    {
        public static Operator GetInstance(string symbol)
        {
            Operator ret = null;
            switch (symbol)
            {
                case "inc":
                    ret = new Incrementor();
                    break;
                case "dec":
                    ret = new Decrementor();
                    break;
            }
            return ret;
        }

        public abstract int Operate(int left, int right);
    }
}