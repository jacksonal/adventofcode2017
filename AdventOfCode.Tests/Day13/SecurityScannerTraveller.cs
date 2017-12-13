using System;
using AdventOfCode.Day13;

namespace AdventOfCode.Tests.Day13
{
    public class SecurityScannerTraveller
    {
        private SecurityScanner _scanner;

        public SecurityScannerTraveller(SecurityScanner scanner)
        {
            CurrentPosition = -1;
            _scanner = scanner;
        }

        public int CurrentPosition { get; set; }

        public int Advance()
        {
            var ret = 0;
            CurrentPosition++;
            if (CurrentPosition < _scanner.Layers.Count)
            {
                var layer = _scanner.Layers[CurrentPosition];
                if (layer.ScannerPosition == 0 && layer.ScanRange != null)
                {
                    ret = (int) layer.ScanRange * CurrentPosition;
                }
                _scanner.Step();
            }
            return ret;
        }

        public bool IsFinished()
        {
            return CurrentPosition >= _scanner.Layers.Count;
        }

        public int MoveToEnd()
        {
            var ret = 0;
            while (!IsFinished())
            {
                ret += Advance();
            }
            return ret;
        }
    }
}