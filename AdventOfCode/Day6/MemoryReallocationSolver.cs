using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day6
{
    public class MemoryReallocationSolver
    {
        public MemoryAllocation Allocation { get; set; }
        public ISet<string> PreviousAllocations { get; }

        public MemoryReallocationSolver(string input)
        {
            Allocation = new MemoryAllocation(input.Split().Where(s=>s!=string.Empty).Select(s=>Convert.ToInt32(s)));
            PreviousAllocations = new HashSet<string>();
            PreviousAllocations.Add(Allocation.ToString());
        }

        public virtual int Solve()
        {
            var ret = 0;
            do
            {
                Allocation.Reallocate();
                ret++;
            } while (PreviousAllocations.Add(Allocation.ToString()));
            return ret;
        }
    }
}