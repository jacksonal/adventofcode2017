using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day16
{
    public class DanceLine
    {
        protected IList<char> _dancers;

        public DanceLine()
        {
            _dancers = new List<char>{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p'};
        }

        public string Solve(string danceMoves)
        {
            var moves = danceMoves.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).Select(DanceMove.GetInstance);
            foreach (var danceMove in moves)
            {
                _dancers = danceMove.Dance(_dancers);
            }
            return string.Join("", _dancers);
        }
    }
}