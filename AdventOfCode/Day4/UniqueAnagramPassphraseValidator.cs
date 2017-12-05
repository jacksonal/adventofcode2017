using System.Net;

namespace AdventOfCode.Day4
{
    public class UniqueAnagramPassphraseValidator : PassphraseValidator
    {
        public override bool IsValid(string phrase)
        {
            var parsedPhrase = new Phrase(phrase);
            return !parsedPhrase.ContainsAnagramDupe();
        }
    }
}