using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day4
{
    public class UniquePassphraseValidator
    {
        public bool IsValid(string phrase)
        {
            var ret = true;
            var set = new HashSet<string>();
            foreach (var word in phrase.Split().Where(s=>s!=string.Empty))
            {
                ret &= set.Add(word);
            }
            return ret;
        }

        public int Solve(string input)
        {
            return input.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries).Count(IsValid);
        }
    }
}