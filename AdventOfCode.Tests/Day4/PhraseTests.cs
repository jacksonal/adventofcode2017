using System.Linq;
using AdventOfCode.Day4;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day4
{
    [TestFixture]
    public class PhraseTests
    {
        [Test]
        public void CreatePhrase_HasRightNumberOfWords()
        {
            var phrase = "test test";
            var obj = new Phrase(phrase);
            Assert.AreEqual(2, obj.Words.Count());
        }

        [Test]
        public void ContainsAnagramDupe_SingleWord_ReturnsFalse()
        {
            var phrase = "test";
            var obj = new Phrase(phrase);
            Assert.IsFalse(obj.ContainsAnagramDupe());
        }

        [Test]
        public void ContainsAnagramDupe_TwoWordsNotAnagramsOfEachother_ReturnsFalse()
        {
            var phrase = "test watch";
            var obj = new Phrase(phrase);
            Assert.IsFalse(obj.ContainsAnagramDupe());
        }

        [Test]
        public void ContainsAnagramDupe_TwoWordsAnagramsOfEachother_ReturnsTrue()
        {
            var phrase = "test stet";
            var obj = new Phrase(phrase);
            Assert.IsTrue(obj.ContainsAnagramDupe());
        }

        [TestCase("abcde fghij")]
        [TestCase("a ab abc abd abf abj")]
        [TestCase("iiii oiii ooii oooi oooo")]
        public void NoAnagramDupesTestCases(string input)
        {
            var phrase = new Phrase(input);
            Assert.IsFalse(phrase.ContainsAnagramDupe());
        }

        [TestCase("abcde xyz ecdab")]
        [TestCase("oiii ioii iioi iiio")]
        public void ContainsAnagramDupesTestCases(string input)
        {
            var phrase = new Phrase(input);
            Assert.IsTrue(phrase.ContainsAnagramDupe());
        }
    }
}