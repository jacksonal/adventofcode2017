using AdventOfCode.Day8;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day8
{
    [TestFixture]
    public class RegisterInstructionsSolverTests
    {
        private RegisterInstructionsSolver _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new RegisterInstructionsSolver();
        }

        [Test]
        public void ParseStatement_ReturnsStatementObject()
        {
            Assert.IsInstanceOf<Statement>(_systemUnderTest.ParseStatement("b inc 5 if a > 1"));
        }

        [Test]
        public void ParseStatement_HasCorrectOperationAndComparator()
        {
            var statement = _systemUnderTest.ParseStatement("b inc 5 if a > 1");
            Assert.IsInstanceOf<Incrementor>(statement.Operator);
            Assert.IsInstanceOf<GreaterThanComparator>(statement.Comparator);
        }

        [TestCase("b inc 5 if a > 1", 0, 5, 0, 1, 0)]
        [TestCase("abc dec 5 if a < 1", 0, 5, 0, 1,-5)]
        public void ParseStatement_HasCorrectValues(string input, int opLeft, int opRight, int compLeft, int compRight, int expected)
        {
            var statement = _systemUnderTest.ParseStatement(input);
            Assert.AreEqual(opLeft,statement.OperateLeft);
            Assert.AreEqual(opRight, statement.OperateRight);
            Assert.AreEqual(compLeft, statement.CompareLeft);
            Assert.AreEqual(compRight, statement.CompareRight);
            Assert.AreEqual(expected, statement.Evaluate());
        }

        [Test]
        public void ExampleTestCase()
        {
            var result = _systemUnderTest.Solve(Resources.ExampleRegisterInstructions);
            Assert.AreEqual(1, result);
        }
    }
}