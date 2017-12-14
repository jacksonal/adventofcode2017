using System;
using System.Linq;
using AdventOfCode.Day10;

namespace AdventOfCode.Day14
{
    public class KnotHashDiskAnalyzer
    {
        protected DenseKnotHashSolver _hashSolver;

        public KnotHashDiskAnalyzer()
        {
            _hashSolver = new DenseKnotHashSolver();
        }

        public virtual int Solve(string input)
        {
            var count = 0;
            for (int i = 0; i < 128; i++)
            {
                var binary = GetHashAsBinary($"{input}-{i}");
                count += binary.Count(c => c == '1');
                _hashSolver.Reset();
            }
            return count;
        }

        public string GetHashAsBinary(string input)
        {
            var ret = "";
            //do all the twisting
            var hash =_hashSolver.GetDenseHash(input);
            ret = ConvertHexStringToBinary(hash);
            return ret;
        }

        public static string ConvertHexStringToBinary(string hash)
        {
            var ret = "";
            foreach (char c in hash)
            {
                ret += ConvertToFourDigitBinary(c);
            }
            return ret;
        }

        public static string ConvertToFourDigitBinary(char c)
        {
            var ret = "";
            var num = Convert.ToInt32(c.ToString(), 16);
            ret = Convert.ToString(num, 2).PadLeft(4, '0');
            return ret;
        }

        public void PrintBinaryHash(string input)
        {
            for (int i = 0; i < 128; i++)
            {
                var hashAsBinary = GetHashAsBinary($"{input}-{i}");
                Console.WriteLine(hashAsBinary);
                _hashSolver.Reset();
            }
        }
    }
}