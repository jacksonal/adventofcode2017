using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode.Day7
{
    public class ProgramTreeNode
    {
        private List<ProgramTreeNode> _children;

        public string Name { get; set; }
        public int Weight { get; set; }
        public IEnumerable<ProgramTreeNode> Children => _children;
        public ProgramTreeNode Parent { get; set; }

        public ProgramTreeNode(string name, int weight)
        {
            Name = name;
            Weight = weight;
            _children = new List<ProgramTreeNode>();
        }
        
        public void AddChild(ProgramTreeNode child)
        {
            _children.Add(child);
            child.Parent = this;
        }
    }
}