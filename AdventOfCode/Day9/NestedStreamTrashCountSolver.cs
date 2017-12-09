namespace AdventOfCode.Day9
{
    public class NestedStreamTrashCountSolver : NestedStreamSolver
    {
        public override int Solve(string input)
        {
            var root = BuildTree(input);
            return root.CountTrash();
        }
    }
}