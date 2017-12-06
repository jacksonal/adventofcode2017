using System.Linq;

namespace AdventOfCode.Day6
{
    public class MemoryReallocationLoopSizeSolver : MemoryReallocationSolver
    {
        public MemoryReallocationLoopSizeSolver(string input) : base(input)
        {
        }

        public override int Solve()
        {
            base.Solve();
            return PreviousAllocations.Count - PreviousAllocations.ToList().IndexOf(Allocation.ToString());
        }
    }
}