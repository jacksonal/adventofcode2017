using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Day16
{
    public class DanceLine
    {
        protected List<char> _dancers;
        private IList<DanceMove> _posMoves;

        public DanceLine()
        {
            _dancers = new List<char>{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p'};
        }

        public string Solve(string danceMoves)
        {
            return DanceXTimes(danceMoves, 1);
        }

        private void Dance()
        {
            foreach (var danceMove in _posMoves)
            {
                _dancers = danceMove.Dance(_dancers);
            }
        }

        public string DanceABillionTimes(string danceMoves)
        {
            return DanceXTimes(danceMoves, 1000000000);
        }

        public string DanceXTimes(string danceMoves, int x)
        {
            var moves = danceMoves.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(DanceMove.GetInstance);

            _posMoves = moves.ToList();
            var seen = new List<string>();
            for (int i = 0; i < x; i++)
            {
                var joined = string.Join("", _dancers);
                if (seen.Contains(joined))
                {
                    return seen[x % i];
                }
                else
                {
                    seen.Add(joined);
                }
                Dance();
            }
            return string.Join("", _dancers);
        }
    }
}