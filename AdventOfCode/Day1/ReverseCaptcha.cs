using System;
using System.Linq;

namespace AdventOfCode.Day1
{
    public class ReverseCaptcha
    {
        public int Solve(string captcha)
        {
            var sum = 0;
            var digits = captcha.Select(c => Int32.Parse(c.ToString())).ToArray();
            for(int i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i] == digits[i + 1])
                {
                    sum += digits[i];
                }
            }
            if (digits.First() == digits.Last())
            {
                sum += digits.First();
            }
            return sum;
        }
    }
}
