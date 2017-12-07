using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Day7
{
    public abstract class ProgramTreeSolver
    {
        private readonly Regex _nodeRegex = new Regex(@"(?<name>[a-zA-Z]+)\s\((?<weight>\d+)\)");
        private IDictionary<string, ProgramTreeNode> _holdingTable = new Dictionary<string, ProgramTreeNode>();
        public Regex NodeRegex => _nodeRegex;
        public abstract string Solve(string input);

        protected ProgramTreeNode BuildTree(string input)
        {
            using (var sr = new StringReader(input))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    Match m = NodeRegex.Match(line);
                    _holdingTable.Add(m.Groups["name"].Value,
                        new ProgramTreeNode(m.Groups["name"].Value, Convert.ToInt32(m.Groups["weight"].Value)));
                    line = sr.ReadLine();
                }
            }

            using (var sr = new StringReader(input))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    if (line.Contains("->"))
                    {
                        var m = NodeRegex.Match(line);
                        foreach (var childKey in line
                            .Split(new[] {"->"}, StringSplitOptions.RemoveEmptyEntries)
                            .Last()
                            .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries))
                        {
                            _holdingTable[m.Groups["name"].Value].AddChild(_holdingTable[childKey]);
                        }
                    }
                    line = sr.ReadLine();
                }
            }
            return FindRoot(_holdingTable.Values.First());
        }

        private ProgramTreeNode FindRoot(ProgramTreeNode node)
        {
            var ret = node;
            while (ret.Parent!=null)
            {
                ret = ret.Parent;
            }
            return ret;
        }
    }

    class ProgramTreeBalanceSolver : ProgramTreeSolver
    {
        public override string Solve(string input)
        {
            BuildTree(input);

            return "";
        }
    }
}