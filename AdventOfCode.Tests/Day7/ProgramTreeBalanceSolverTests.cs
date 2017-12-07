using AdventOfCode.Day7;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day7
{
    [TestFixture]
    public class ProgramTreeBalanceSolverTests
    {
        private ProgramTreeBalanceSolver _systemUnderTest;

        [SetUp]
        public void BeforEach()
        {
            _systemUnderTest = new ProgramTreeBalanceSolver();
        }
        [Test]
        public void IsBalanced_TrueIfChildrenAllSameWeight()
        {
            var root = new ProgramTreeNode("test", 6);
            root.AddChild(new ProgramTreeNode("test",2));
            root.AddChild(new ProgramTreeNode("test", 2));
            root.AddChild(new ProgramTreeNode("test", 2));

            Assert.IsTrue(_systemUnderTest.IsBalanced(root));
        }

        [Test]
        public void IsBalanced_FalseIfChildrenNotAllSameWeight()
        {
            var root = new ProgramTreeNode("test", 7);
            root.AddChild(new ProgramTreeNode("test", 2));
            root.AddChild(new ProgramTreeNode("test", 3));
            root.AddChild(new ProgramTreeNode("test", 2));

            Assert.IsFalse(_systemUnderTest.IsBalanced(root));
        }

        [Test]
        public void GetSubtreeWeight_CalculatesWeightCorrectly()
        {
            var root = new ProgramTreeNode("test", 7);
            root.AddChild(new ProgramTreeNode("test", 2));
            root.AddChild(new ProgramTreeNode("test", 3));
            root.AddChild(new ProgramTreeNode("test", 2));

            Assert.AreEqual(14, _systemUnderTest.GetSubTreeWeight(root));
        }

        [Test]
        public void Solve_GetsValueForNodeThatWouldBalanceTree()
        {
            Assert.AreEqual("60",_systemUnderTest.Solve(Resources.ExampleProgramTree));
        }
    }
}