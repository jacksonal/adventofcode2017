using System.Linq;
using AdventOfCode.Day7;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day7
{
    [TestFixture]
    public class ProgramTreeNodeTests
    {
        [Test]
        public void CreateNode_GivenNameAndWeight_PropertiesCorrect()
        {
            var name = "test";
            var weight = 123;
            var node = new ProgramTreeNode(name, weight);

            Assert.AreEqual(name, node.Name);
            Assert.AreEqual(weight, node.Weight);
        }

        [Test]
        public void AddChild_ChildNodeAddedToChildrenCollection()
        {
            var parent = new ProgramTreeNode("test",1);
            var child = new ProgramTreeNode("child",1);

            parent.AddChild(child);

            Assert.Contains(child,parent.Children.ToList());
        }

        [Test]
        public void AddChild_ChildNodeHasReferenceToParent()
        {
            var parent = new ProgramTreeNode("test", 1);
            var child = new ProgramTreeNode("child", 1);

            parent.AddChild(child);

            Assert.AreEqual(parent, child.Parent);
        }
    }
}