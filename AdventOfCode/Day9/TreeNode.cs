using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day9
{
    public class TreeNode
    {
        private List<TreeNode> _children;
        public int TrashCount { get; set; }

        public TreeNode()
        {
            TrashCount = 0;
            _children = new List<TreeNode>();
        }

        public IEnumerable<TreeNode> Children => _children;

        public void AddChild(TreeNode node)
        {
            _children.Add(node);
        }

        public int GetScore(int parentDepth)
        {
            return parentDepth + 1 + _children.Select(c=>c.GetScore(parentDepth + 1)).Sum();
        }

        public int CountNodes()
        {
            return 1 + _children.Select(c=>c.CountNodes()).Sum();
        }

        public int CountTrash()
        {
            return TrashCount + _children.Select(c => c.CountTrash()).Sum();
        }
    }
}