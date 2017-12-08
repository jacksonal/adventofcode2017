using AdventOfCode.Day8;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day8
{
    public class StatementTests
    {
        [Test]
        public void Evaluate_ReturnsExpectedValue()
        {
            var statement = new Statement();
            statement.Operator = new Incrementor();
            statement.Comparator = new EqualComparator();
            statement.CompareLeft = 4;
            statement.CompareRight = 4;
            statement.OperateLeft = 5;
            statement.OperateRight = 8;
            Assert.AreEqual(13,statement.Evaluate());
        }
    }
}