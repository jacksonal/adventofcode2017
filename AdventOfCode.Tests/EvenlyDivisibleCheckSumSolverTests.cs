using AdventOfCode.Day2;
using NUnit.Framework;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class EvenlyDivisibleCheckSumSolverTests
    {
        private EvenlyDivisibleCheckSumSolver _systemUnderTest;

        [Test]
        public void GetRowCheckSum_ReturnsOnlyEvenlyDivisibleResult()
        {
            _systemUnderTest = new EvenlyDivisibleCheckSumSolver();
            var input = new[] {5, 9, 2, 8};
            var result = _systemUnderTest.GetRowCheckSum(input);
        }
    }
}