using System;
using AdventOfCode.Day14;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day14
{
    public class KnotHashDiskAnalyzerTests
    {
        private KnotHashDiskAnalyzer _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new KnotHashDiskAnalyzer();
        }

        [TestCase("flqrgnkx-0", "11010100")]
        [TestCase("flqrgnkx-1", "01010101")]
        [TestCase("flqrgnkx-2", "00001010")]
        [TestCase("flqrgnkx-3", "10101101")]
        [TestCase("flqrgnkx-4", "01101000")]
        [TestCase("flqrgnkx-5", "11001001")]
        [TestCase("flqrgnkx-6", "01000100")]
        [TestCase("flqrgnkx-7", "11010110")]
        public void GetHashAsBinary_StartsWithExpected(string input, string startsWith)
        {
            var hash = _systemUnderTest.GetHashAsBinary(input);
            Assert.AreEqual(128,hash.Length);
            Assert.IsTrue(hash.StartsWith(startsWith), $"Expected {startsWith}, but was {hash.Substring(0,8)}");
        }

        [TestCase('0', "0000")]
        [TestCase('1', "0001")]
        [TestCase('e', "1110")]
        [TestCase('f', "1111")]
        public void ConvertToFourDigitBinary_IsCorrect(char input, string expected)
        {
            Assert.AreEqual(expected, KnotHashDiskAnalyzer.ConvertToFourDigitBinary(input));
        }

        [TestCase("a0c2017", "1010000011000010000000010111")]
        public void ConvertHexToBinary(string input, string startsWith)
        {
            var result = KnotHashDiskAnalyzer.ConvertHexStringToBinary(input);
            Assert.IsTrue(result.StartsWith(startsWith), $"Expected {startsWith}, but was {result}");
        }
        [Test]
        //[Ignore("long")]
        public void ExampleTestCase()
        {
            Assert.AreEqual(8108, _systemUnderTest.Solve("flqrgnkx"));
        }

        [Test]
        public void ExamplePrint()
        {
            _systemUnderTest.PrintBinaryHash("flqrgnkx");
        }
    }
}