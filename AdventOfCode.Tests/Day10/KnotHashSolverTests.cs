using AdventOfCode.Day10;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day10
{
    [TestFixture]
    public class KnotHashSolverTests
    {
        private KnotHashSolver _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new KnotHashSolver();
            _systemUnderTest.ProblemSet = new[] {0, 1, 2, 3, 4};
        }

        [Test]
        public void Twist_ReversesTheSubArray()
        {
            var result = _systemUnderTest.Twist(new[] {1, 2, 3});

            Assert.AreEqual(3,result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(1, result[2]);
        }

        [Test]
        public void Create_HasReferenceToCurrentPosition()
        {
            Assert.AreEqual(0,_systemUnderTest.CurrentPosition);
        }

        [Test]
        public void Create_HasReferenceToSkipSize()
        {
            Assert.AreEqual(0, _systemUnderTest.SkipSize);
        }

        [Test]
        public void TwistLength_ReversesProblemSetInPlace()
        {
            _systemUnderTest.TwistLength(3);
            Assert.AreEqual(2,_systemUnderTest.ProblemSet[0]);
            Assert.AreEqual(1, _systemUnderTest.ProblemSet[1]);
            Assert.AreEqual(0, _systemUnderTest.ProblemSet[2]);
            Assert.AreEqual(3, _systemUnderTest.ProblemSet[3]);
            Assert.AreEqual(4, _systemUnderTest.ProblemSet[4]);
        }
        [Test]
        public void TwistLength_IncrementsCurrentPositionByLengthPlusSkipSize()
        {
            _systemUnderTest.SkipSize = 1;
            _systemUnderTest.TwistLength(3);
            Assert.AreEqual(4, _systemUnderTest.CurrentPosition);
            Assert.AreEqual(2, _systemUnderTest.SkipSize);
        }

        [Test]
        public void TwistLength_LengthWrapsAround()
        {
            _systemUnderTest.CurrentPosition = 3;
            _systemUnderTest.TwistLength(3);
            Assert.AreEqual(3, _systemUnderTest.ProblemSet[0]);
            Assert.AreEqual(1, _systemUnderTest.ProblemSet[1]);
            Assert.AreEqual(2, _systemUnderTest.ProblemSet[2]);
            Assert.AreEqual(0, _systemUnderTest.ProblemSet[3]);
            Assert.AreEqual(4, _systemUnderTest.ProblemSet[4]);

            Assert.AreEqual(1, _systemUnderTest.CurrentPosition);
        }

        [TestCase("3,4,1,5", new[] {3, 4, 2, 1, 0}, 12)]
        [TestCase("3,4,1", new[] { 4, 3, 0, 1, 2 }, 12)]
        [TestCase("3,4", new[] { 4, 3, 0, 1, 2 }, 12 )]
        [TestCase("3", new[] { 2, 1, 0, 3, 4 }, 2)]
        public void ExampleTestCase(string input, int[] expectedProblemSet, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _systemUnderTest.Solve(input));
            Assert.AreEqual(expectedProblemSet[0], _systemUnderTest.ProblemSet[0]);
            Assert.AreEqual(expectedProblemSet[1], _systemUnderTest.ProblemSet[1]);
            Assert.AreEqual(expectedProblemSet[2], _systemUnderTest.ProblemSet[2]);
            Assert.AreEqual(expectedProblemSet[3], _systemUnderTest.ProblemSet[3]);
            Assert.AreEqual(expectedProblemSet[4], _systemUnderTest.ProblemSet[4]);
        }
    }
}