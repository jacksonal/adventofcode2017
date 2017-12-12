using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day12
{
    public class ProgramGraph
    {
        private readonly Dictionary<int,ProgramGraphNode> _table = new Dictionary<int, ProgramGraphNode>();
        public ProgramGraphNode GetNode(int id)
        {
            return _table[id];
        }

        public void AddNode(int id)
        {
            if (!_table.ContainsKey(id))
            {
                _table[id] = new ProgramGraphNode(id);
            }
        }

        public int CountNodes(int id)
        {
            var start = GetNode(id);

            return start.CountGraph();
        }

        public int CountGroups()
        {
            var groups = 0;
            var visited = new List<int>();
            while (_table.Keys.Except(visited).Any())
            {
                var startId = _table.Keys.Except(visited).First();
                var startNode = GetNode(startId);
                startNode.VisitAllNodes(startNode,visited);
                groups++;
            }
            return groups;
        }
    }
}