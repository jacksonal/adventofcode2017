using System;
using System.Linq;

namespace AdventOfCode.Day1
{
    public class ReverseCaptchaNextDuplicate : ReverseCaptcha
    {
        protected override int SumArray(int[] digits)
        {
            var sum = 0;
            for (int i = 0; i < digits.Length - 1; i++)
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
