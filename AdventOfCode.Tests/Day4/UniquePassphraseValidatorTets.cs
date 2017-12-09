using System;
using AdventOfCode.Day4;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day4
{
    [TestFixture]
    public class UniquePassphraseValidatorTets
    {
        private UniquePassphraseValidator _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new UniquePassphraseValidator();
        }
        [Test]
        public void IsValid_GivenSingleWord_ReturnsTrue()
        {
            Assert.IsTrue(_systemUnderTest.IsValid("test"));
        }

        [Test]
        public void IsValid_GivenTwoIdenticalWords_ReturnsFalse()
        {
            Assert.IsFalse(_systemUnderTest.IsValid("test test"));
        }

        [Test]
        public void Solve_GivenOneValidOneInvalid_ReturnsCountOfValidPhrases()
        {
            var input = "test" + Environment.NewLine + "test test";
            Assert.AreEqual(1, _systemUnderTest.Solve(input));
        }

        [TestCase("aa bb cc dd ee")]
        [TestCase("aa bb cc dd aaa")]
        public void ValidTestCases(string input)
        {
            Assert.IsTrue(_systemUnderTest.IsValid(input));
        }

        [TestCase("aa bb cc dd aa")]
        public void InvalidTestCases(string input)
        {
            Assert.IsFalse(_systemUnderTest.IsValid(input));
        }
    }
}