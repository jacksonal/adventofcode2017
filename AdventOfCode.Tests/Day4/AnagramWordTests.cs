using AdventOfCode.Day4;
using NUnit.Framework;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class AnagramWordTests
    {
        [Test]
        public void CreateWord_HasRightNumberOfLetters()
        {
            var word = "test";
            var obj = new AnagramWord(word);
            Assert.AreEqual(4, obj.Length);
        }

        [Test]
        public void IsAnagramOf_WordsDifferentLengh_ReturnsFalse()
        {
            var word1 = "test";
            var parsed1 = new AnagramWord(word1);
            var word2 = "set";
            var parsed2 = new AnagramWord(word2);

            Assert.IsFalse(parsed1.IsAnagramOf(parsed2));
            Assert.IsFalse(parsed2.IsAnagramOf(parsed1));
        }

        [Test]
        public void IsAnagramOf_WordsSameLenghAndNotAnagrams_ReturnsFalse()
        {
            var word1 = "test";
            var parsed1 = new AnagramWord(word1);
            var word2 = "seti";
            var parsed2 = new AnagramWord(word2);

            Assert.IsFalse(parsed1.IsAnagramOf(parsed2));
            Assert.IsFalse(parsed2.IsAnagramOf(parsed1));
        }

        [Test]
        public void IsAnagramOf_WordsAreAnagrams_ReturnsTrue()
        {
            var word1 = "test";
            var parsed1 = new AnagramWord(word1);
            var word2 = "sett";
            var parsed2 = new AnagramWord(word2);

            Assert.IsTrue(parsed1.IsAnagramOf(parsed2));
            Assert.IsTrue(parsed2.IsAnagramOf(parsed1));
        }
    }
}