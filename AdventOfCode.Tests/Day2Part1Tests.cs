using System;
using System.Linq;
using AdventOfCode.Day2;
using NUnit.Framework;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class Day2Part1Tests
    {
        private BiggestDiffCheckSumSolver _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new BiggestDiffCheckSumSolver();
        }

        [Test]
        public void GetLargestDifference_FindsLargestDiff()
        {
            var input = new []{12, 45, 32, 102, 76, 33};
            var result = _systemUnderTest.GetRowCheckSum(input);
            Assert.AreEqual(90, result);
        }

        [Test]
        public void ConvertToIntArray_ParsesStringToInt()
        {
            var input = "1  2   3 4";
            var result = _systemUnderTest.ParseRow(input).ToArray();

            for (int i = 1; i <= result.Length; i++)
            {
                Assert.AreEqual(i,result[i-1]);
            }
        }
        [Test]
        public void Solve_SumsGetLargestDiffForEachRow()
        {
            var input = "1  2   3 4" + Environment.NewLine + "5 6 7 8";
            var result = _systemUnderTest.Solve(input);
            Assert.AreEqual(6, result);
        }
    }
}