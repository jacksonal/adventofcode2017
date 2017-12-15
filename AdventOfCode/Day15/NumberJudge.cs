using System;

namespace AdventOfCode.Day15
{
    public class NumberJudge
    {
        public void Compare(long first, long second)
        {
            var firstBinary = Convert.ToString(first, 2).PadLeft(16,'0');
            var secondBinary = Convert.ToString(second, 2).PadLeft(16, '0');
            if (firstBinary.Substring(firstBinary.Length - 16) == secondBinary.Substring(secondBinary.Length - 16))
            {
                ValidCount++;
            }
        }

        public int ValidCount { get; set; }
    }
}