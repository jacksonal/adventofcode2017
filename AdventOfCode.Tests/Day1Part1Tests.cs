using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode.Day1;
using NUnit.Framework;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class Day1Part1Tests
    {
        private ReverseCaptchaNextDuplicate _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new ReverseCaptchaNextDuplicate();
        }

        [Test]
        public void SingleDigitString_ReturnsSelfAsInt()
        {
            //last digit loops back to check the first.
            var captcha = "5";

            var result = _systemUnderTest.Solve(captcha);

            Assert.AreEqual(Convert.ToInt32(captcha),result);
        }

        [Test]
        public void LongerStringWithSingleDuplicateInMiddle_ReturnsThatSum()
        {
            //sum of digits that immediately repeat should be 4 here.
            var captcha = "123445";

            var result = _systemUnderTest.Solve(captcha);

            Assert.AreEqual(4, result);
        }

        [TestCase("1122", 3)]
        [TestCase("1111", 4)]
        [TestCase("1234", 0)]
        [TestCase("91212129", 9)]
        public void ExampleTestCases(string input, int expected)
        {
            Assert.AreEqual(expected,_systemUnderTest.Solve(input));
        }
    }
}
