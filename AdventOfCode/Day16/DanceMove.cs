using System;

namespace AdventOfCode.Day16
{
    public abstract class DanceMove
    {
        public static DanceMove GetInstance(string move)
        {
            DanceMove ret;
            var type = move[0];
            switch (type)
            {
                case 'x':
                    ret = new ExchangeMove();
                    break;
                case 's':
                    ret = new SpinMove();
                    break;
                case 'p':
                    ret = new PartnerMove();
                    break;
                default:
                    throw new ArgumentException();
            }
            return ret;
        }
    }

    public class PartnerMove : DanceMove
    {
    }

    public class ExchangeMove : DanceMove
    {
    }

    public class SpinMove : DanceMove
    {
    }
}