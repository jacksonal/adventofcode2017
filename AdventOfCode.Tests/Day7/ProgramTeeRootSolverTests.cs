using AdventOfCode.Day7;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day7
{
    [TestFixture]
    public class ProgramTeeRootSolverTests
    {
        private ProgramTreeRootSolver _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new ProgramTreeRootSolver();
        }

        [Test]
        public void GivenTestInput_Solve_FindsRoot()
        {
            var result = _systemUnderTest.Solve(Resources.ExampleProgramTree);

            Assert.AreEqual("tknk", result);
        }

        [TestCase("pbga (66)")]
        [TestCase("padx (45) -> pbga, havc, qoyq")]
        public void NodeRegex_MatchesLinesInInput(string nodeLine)
        {
            Assert.IsTrue(_systemUnderTest.NodeRegex.IsMatch(nodeLine));
        }
    }
}