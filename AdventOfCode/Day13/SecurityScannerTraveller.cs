using System;
using AdventOfCode.Day13;

namespace AdventOfCode.Day13
{
    public class SecurityScannerTraveller
    {
        protected SecurityScanner _scanner;

        public SecurityScannerTraveller(SecurityScanner scanner)
        {
            CurrentPosition = -1;
            _scanner = scanner;
            IsCaught = false;
        }

        public int CurrentPosition { get; set; }
        public bool IsCaught { get; set; }

        public int Advance()
        {
            var ret = 0;
            CurrentPosition++;
            if (CurrentPosition < _scanner.Layers.Count)
            {
                var layer = _scanner.Layers[CurrentPosition];
                if (layer.ScannerPosition == 0 && layer.ScanRange != null)
                {
                    IsCaught = true;
                    ret = (int) layer.ScanRange * CurrentPosition;
                }
                _scanner.Step();
            }
            return ret;
        }

        public virtual bool IsFinished()
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

        public void Reset()
        {
            IsCaught = false;
            CurrentPosition = -1;
        }
    }
}