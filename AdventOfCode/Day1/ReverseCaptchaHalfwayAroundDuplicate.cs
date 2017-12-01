using System;
using System.Linq;

namespace AdventOfCode.Day1
{
    public class ReverseCaptchaHalfwayAroundDuplicate : ReverseCaptcha
    {
        protected override int SumArray(int[] digits)
        {
            var sum = 0;
            var halfStep = digits.Length/2;
            for (int i = 0; i < halfStep; i++)
            {
                if (digits[i] == digits[i + halfStep])
                {
                    sum += digits[i] * 2;
                }
            }
            return sum;
        }
    }
}