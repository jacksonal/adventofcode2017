using System.Linq;
using AdventOfCode.Day12;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day12
{
    [TestFixture]
    public class ProgramGraphTests
    {
        private ProgramGraphBuilder _systemUnderTest;

        [Test]
        public void AddNeighbor_AddsNeighborOnBothSides()
        {
            var a = new ProgramGraphNode(1);
            var b = new ProgramGraphNode(2);

            a.AddNeighbor(b);
            Assert.Contains(a, b.Neighbors.ToList());
            Assert.Contains(b, a.Neighbors.ToList());
        }

        [Test]
        public void CanReach_GivenNeighbor_ReturnsTrue()
        {
            var a = new ProgramGraphNode(1);
            var b = new ProgramGraphNode(2);

            a.AddNeighbor(b);
            Assert.IsTrue(a.CanReach(b.Id));
            Assert.IsTrue(b.CanReach(a.Id));
        }

        [Test]
        public void CanReach_GivenSelf_ReturnsTrue()
        {
            var a = new ProgramGraphNode(1);
            
            Assert.IsTrue(a.CanReach(1));
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        public void CanReach_GivenSmallGraph_FindsConnections(int id)
        {
            _systemUnderTest = new ProgramGraphBuilder();
            var graph = _systemUnderTest.BuildGraph(Resources.ExampleCommunicationGraph);
            Assert.IsTrue(graph.GetNode(0).CanReach(id));
        }

        [Test]
        public void CountNodes_GivenSmallGraph_ReturnsCorrectCount()
        {
            _systemUnderTest = new ProgramGraphBuilder();
            var graph = _systemUnderTest.BuildGraph(Resources.ExampleCommunicationGraph);
            Assert.AreEqual(6, graph.CountNodes(0));
        }

        [Test]
        public void CountGroups_GivenSmallGraph_ReturnsCorrectCount()
        {
            _systemUnderTest = new ProgramGraphBuilder();
            var graph = _systemUnderTest.BuildGraph(Resources.ExampleCommunicationGraph);
            Assert.AreEqual(2, graph.CountGroups());
        }
    }
}