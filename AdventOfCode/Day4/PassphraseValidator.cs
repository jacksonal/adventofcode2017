using System;
using System.Linq;

namespace AdventOfCode.Day4
{
    public abstract class PassphraseValidator
    {
        public abstract bool IsValid(string phrase);

        public int Solve(string input)
        {
            return input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).Count(IsValid);
        }
    }
}