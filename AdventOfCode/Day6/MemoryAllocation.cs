using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day6
{
    public class MemoryAllocation
    {
        public IList<int> Buckets { get; set; }
        public MemoryAllocation(IEnumerable<int> memBuckets)
        {
            Buckets = memBuckets.ToList();
        }

        public override string ToString()
        {
            return string.Join(",", Buckets);
        }

        public void Reallocate()
        {
            var max = Buckets.Max();
            var index = Buckets.IndexOf(max);
            Buckets[index] = 0;
            index = IncrementWithRollover(index, Buckets.Count);
            for (; max > 0; index = IncrementWithRollover(index,Buckets.Count))
            {
                Buckets[index]++;
                max--;
            }
        }

        private int IncrementWithRollover(int index, int size)
        {
            return (index + 1) % size;
        }
    }
}