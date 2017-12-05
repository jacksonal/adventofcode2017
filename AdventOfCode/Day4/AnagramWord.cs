using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day4
{
    public class AnagramWord
    {
        private IDictionary<char, int> _letters;
        private string _word;

        public AnagramWord(string word)
        {
            _word = word;
            _letters = new Dictionary<char, int>();
            foreach (var letter in word.ToCharArray())
            {
                if (!_letters.ContainsKey(letter))
                {
                    _letters.Add(letter,0);
                }
                _letters[letter]++;
            }
        }

        public IEnumerable<char> Letters => _letters.Keys;
        public int Length => _word.Length;

        public bool IsAnagramOf(AnagramWord toCompare)
        {
            var ret = true;
            if (toCompare.Letters.Count() != Letters.Count())
            {
                ret = false;
            }
            else
            {
                foreach (var key in _letters.Keys)
                {
                    if (toCompare.GetLetterCount(key) != _letters[key])
                    {
                        ret = false;
                    }
                }
            }
            return ret;
        }

        private int GetLetterCount(char letter)
        {
            var ret = 0;
            if (_letters.ContainsKey(letter))
            {
                ret = _letters[letter];
            }
            return ret;
        }
    }
}