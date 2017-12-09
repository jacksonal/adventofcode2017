using System.IO;
using System.Linq;
using AdventOfCode.Day9;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day9
{
    [TestFixture]
    public class NestedStreamSolverTests
    {
        private NestedStreamSolver _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new NestedStreamSolver();
        }
        [Test]
        public void BuildTree_SingleNode()
        {
            var root = _systemUnderTest.BuildTree("{}");
            Assert.AreEqual(0,root.Children.Count());
        }

        [Test]
        public void BuildTree_RootWithLeaf()
        {
            var root = _systemUnderTest.BuildTree("{{}}");
            Assert.AreEqual(1, root.Children.Count());
        }

        [Test]
        public void BuildTree_RootWith2Leaf()
        {
            var root = _systemUnderTest.BuildTree("{{},{{}}}");
            Assert.AreEqual(2, root.Children.Count());
            Assert.AreEqual(0, root.Children.First().Children.Count());
            Assert.AreEqual(1, root.Children.Last().Children.Count());
        }
        [Test]
        public void BuildTree_RootWithTrashLeafWithBraces()
        {
            var root = _systemUnderTest.BuildTree("{{<},{{}>}}");
            Assert.AreEqual(1, root.Children.Count());
            Assert.AreEqual(0, root.Children.First().Children.Count());
        }

        [Test]
        public void GetScore_Root_ReturnsZero()
        {
            var node = new TreeNode();
            Assert.AreEqual(1,node.GetScore(0));
        }

        [Test]
        public void GetScore_RootWith2Children_Returns5()
        {
            var node = new TreeNode();
            node.AddChild(new TreeNode());
            node.AddChild(new TreeNode());
            Assert.AreEqual(5, node.GetScore(0));
        }

        [TestCase("{{<a>},{<a>},{<a>},{<a>}}", 4)]
        [TestCase("{<>,{}}", 1)]
        [TestCase("{{<!>},{<!>},{<!>},{<a>}}", 1)]
        public void BuildTree_TrashNotANode(string input, int rootChildren)
        {
            var root = _systemUnderTest.BuildTree(input);
            Assert.AreEqual(rootChildren, root.Children.Count());
        }

        [TestCase("{{<a>},{<a>},{<a>},{<a>}}", 5)]
        [TestCase("{}", 1)]
        [TestCase("{{<!>},{<!>},{<!>},{<a>}}", 2)]
        [TestCase("{{{}}}",3)]
        [TestCase("{{},{}}", 3)]
        [TestCase("{{{},{},{{}}}}",6)]
        [TestCase("{<{},{},{{}}>}",1)]
        [TestCase("{<a>,<a>,<a>,<a>}", 1)]
        [TestCase("{{<a>},{<a>},{<a>},{<a>}}",5)]
        public void CountGroupsTestCases(string input, int groupCount)
        {
            Assert.AreEqual(groupCount,_systemUnderTest.BuildTree(input).CountNodes());
        }

        [TestCase("<>",0)]
        [TestCase("<random characters>", 17)]
        [TestCase("<<<<>", 3)]
        [TestCase("<{!>}>", 2)]
        [TestCase("<!!!>>", 0)]
        [TestCase("<!!>", 0)]
        [TestCase("<{o\"i!a,<{i<a>", 10)]
        public void ParseTrash_ReturnsNumberOfNonCanceledTrashChars(string input, int trashCount)
        {
            Assert.AreEqual(trashCount, _systemUnderTest.ParseTrash(new StringReader(input.Substring(1))));
        }

        [TestCase("<>", 0)]
        [TestCase("<random characters>", 17)]
        [TestCase("<<<<>", 3)]
        [TestCase("<{!>}>", 2)]
        [TestCase("<!!!>>", 0)]
        [TestCase("<!!>", 0)]
        [TestCase("<{o\"i!a,<{i<a>", 10)]
        [TestCase("{<{o\"i!a,<{i<a>},{<{!>}>,<<<<>}", 15)]
        public void TrashCount(string input, int expected)
        {
            var root = _systemUnderTest.BuildTree($"{{{input}}}");
            Assert.AreEqual(expected,root.CountTrash());
        }
    }
}