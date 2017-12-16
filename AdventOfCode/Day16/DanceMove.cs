using System;
using System.Collections.Generic;

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
                    ret = new ExchangeMove(move.Substring(1));
                    break;
                case 's':
                    ret = new SpinMove(move.Substring(1));
                    break;
                case 'p':
                    ret = new PartnerMove(move.Substring(1));
                    break;
                default:
                    throw new ArgumentException();
            }
            return ret;
        }

        public abstract List<char> Dance(IList<char> positions);
    }
}