using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day12
{
    public class ProgramGraphNode
    {
        private List<ProgramGraphNode> _neighbors;

        public IEnumerable<ProgramGraphNode> Neighbors => _neighbors;
        public int Id { get; }

        public ProgramGraphNode(int id)
        {
            _neighbors = new List<ProgramGraphNode>();
            Id = id;
        }

        public void AddNeighbor(ProgramGraphNode neighbor)
        {
            if (!_neighbors.Contains(neighbor))
            {
                _neighbors.Add(neighbor);
                neighbor.AddNeighbor(this);
            }
            
        }

        public bool CanReach(int id)
        {
            return CanReach(id, this,new List<int>());
        }

        private bool CanReach(int id, ProgramGraphNode cur, List<int> visited)
        {
            var ret = false;
            if (id == cur.Id)
            {
                return true;
            }
            else if(!visited.Contains(cur.Id))
            {
                visited.Add(cur.Id);
                foreach (var node in cur.Neighbors)
                {
                    if (!ret)
                    {
                        ret = CanReach(id, node, visited);
                    }
                }
            }
            return ret;
        }

        public int CountGraph()
        {
            return CountGraph(this, new List<int>());
        }

        private int CountGraph(ProgramGraphNode cur, List<int> visited)
        {
            var ret = 0;
            if (!visited.Contains(cur.Id))
            {
                ret = 1;
                visited.Add(cur.Id);
                foreach (var node in cur.Neighbors)
                {
                    
                    ret += CountGraph(node, visited);
                    
                }
            }
            return ret;
        }

        public void VisitAllNodes(ProgramGraphNode cur, List<int> visited)
        {
            if (!visited.Contains(cur.Id))
            {
                visited.Add(cur.Id);
                foreach (var node in cur.Neighbors)
                {
                    VisitAllNodes(node, visited);
                }
            }
        }
    }
}