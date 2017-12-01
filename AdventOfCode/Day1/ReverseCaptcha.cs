using System;
using System.Linq;

namespace AdventOfCode.Day1
{
    public abstract class ReverseCaptcha
    {
        public int Solve(string captcha)
        {
            var digits = captcha.Select(c => Int32.Parse(c.ToString())).ToArray();
            
            return SumArray(digits);
        }

        protected abstract int SumArray(int[] digits);
    }
}