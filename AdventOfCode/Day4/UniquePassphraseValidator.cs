using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day4
{
    public class UniquePassphraseValidator : PassphraseValidator
    {
        public override bool IsValid(string phrase)
        {
            var ret = true;
            var set = new HashSet<string>();
            foreach (var word in phrase.Split().Where(s=>s!=string.Empty))
            {
                ret &= set.Add(word);
            }
            return ret;
        }
    }
}