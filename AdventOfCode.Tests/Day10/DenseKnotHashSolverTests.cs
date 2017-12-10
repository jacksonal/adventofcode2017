using System.Linq;
using AdventOfCode.Day10;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day10
{
    [TestFixture]
    public class DenseKnotHashSolverTests
    {
        private DenseKnotHashSolver _systemUnderTest;

        [Test]
        public void XOR_TestCase()
        {
            _systemUnderTest = new DenseKnotHashSolver();
            _systemUnderTest.ProblemSet = new[] {65, 27, 9, 1, 4, 3, 40, 50, 91, 7, 6, 0, 2, 5, 68, 22};
            var hash = _systemUnderTest.CreateDenseHash();
            Assert.AreEqual(64,hash.First());
        }

        [TestCase("", "a2582a3a0e66e6e86e3812dcb672a272")]
        [TestCase("AoC 2017", "33efeb34ea91902bb2f59c9920caa6cd")]
        [TestCase("1,2,3", "3efbe78a8d82f29979031a4aa0b16a9d")]
        [TestCase("1,2,4", "63960835bcdc130f0b66d7ff4f6a5a8e")]
        public void ExampleTestCases(string input, string expected)
        {
            _systemUnderTest = new DenseKnotHashSolver();
            Assert.AreEqual(expected,_systemUnderTest.GetDenseHash(input));
        }
    }
}