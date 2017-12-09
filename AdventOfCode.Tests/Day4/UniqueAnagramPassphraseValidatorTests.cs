using System;
using AdventOfCode.Day4;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day4
{
    [TestFixture]
    public class UniqueAnagramPassphraseValidatorTests
    {
        private UniqueAnagramPassphraseValidator _systemUnderTest;

        [TestCase]
        public void OneValidOneInvalid_ReturnsOne()
        {
            _systemUnderTest = new UniqueAnagramPassphraseValidator();
            var input = "abcde fghij" + Environment.NewLine + "abcde xyz ecdab";
            Assert.AreEqual(1, _systemUnderTest.Solve(input));
        }
    }
}