using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day4
{
    public class Phrase
    {
        public Phrase(string phrase)
        {
            Words = phrase.Split().Where(s => s != string.Empty).Select(w=>new AnagramWord(w)).ToArray();
        }

        public IEnumerable<AnagramWord> Words { get; set; }

        public bool ContainsAnagramDupe()
        {
            var ret = false;
            if (Words.Count() > 1)
            {
                var words = Words.ToArray();
                for (int i = 0; i < words.Length - 1; i++)
                {
                    var start = words[i];
                    for (int j = i+1; j < words.Length; j++)
                    {
                        if (start.IsAnagramOf(words[j]))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }
    }
}