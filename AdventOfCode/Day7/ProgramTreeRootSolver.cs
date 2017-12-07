namespace AdventOfCode.Day7
{
    public class ProgramTreeRootSolver : ProgramTreeSolver
    {
        public override string Solve(string input)
        {
            var root = BuildTree(input);

            return root.Name;
        }
    }
}