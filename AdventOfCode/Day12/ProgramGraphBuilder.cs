using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using AdventOfCode.Day7;

namespace AdventOfCode.Day12
{
    public class ProgramGraphBuilder
    {
        
        public ProgramGraph BuildGraph(string input)
        {
            var ret = new ProgramGraph();
            using (var sr = new StringReader(input))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    var parts = line.Split(new []{"<->"},StringSplitOptions.RemoveEmptyEntries);
                    var nodeId = Convert.ToInt32(parts[0]);
                    ret.AddNode(nodeId);
                    var node = ret.GetNode(nodeId);
                    foreach (var neighborId in parts[1].Split(new []{','}, StringSplitOptions.RemoveEmptyEntries).Select(n=>Convert.ToInt32(n.Trim())))
                    {
                        ret.AddNode(neighborId);
                        var n = ret.GetNode(neighborId);
                        node.AddNeighbor(n);
                    }
                    line = sr.ReadLine();
                }
            }
            return ret;
        }

        
    }
}