using AdventOfCode.Day1;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day1
{
    [TestFixture]
    public class ReverseCaptchaHalfwayAroundDuplicateTests
    {
        private ReverseCaptchaHalfwayAroundDuplicate _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new ReverseCaptchaHalfwayAroundDuplicate();
        }

        [Test]
        public void ValueSummedIfHalfwayAroundArray()
        {
            var input = "12345278";

            var result = _systemUnderTest.Solve(input);
            Assert.AreEqual(4,result);
        }

        [TestCase("1212",6)]
        [TestCase("1221", 0)]
        [TestCase("123425", 4)]
        [TestCase("123123", 12)]
        [TestCase("12131415", 4)]
        public void ExampleTestCases(string input, int expected)
        {
            Assert.AreEqual(expected, _systemUnderTest.Solve(input));
        }
    }
}