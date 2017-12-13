namespace AdventOfCode.Day13
{
    public class FireWallLayer
    {
        private ScanDirection _scanDirection;

        public ScanDirection ScanDirection
        {
            get => _scanDirection;
            set => _scanDirection = value;
        }

        public int? ScanRange { get; set; }

        public int ScannerPosition { get; set; }

        public FireWallLayer()
        {
            _scanDirection = ScanDirection.Up;
        }

        public void AdvanceScanner()
        {
            if (ScanRange != null)
            {
                if (ScannerPosition == ScanRange - 1)
                {
                    _scanDirection = ScanDirection.Down;
                }
                else if (ScannerPosition == 0)
                {
                    _scanDirection = ScanDirection.Up;
                }

                switch (_scanDirection)
                {
                    case ScanDirection.Up:
                        ScannerPosition++;
                        break;
                    case ScanDirection.Down:
                        ScannerPosition--;
                        break;
                }
            }
        }

        public void Reset()
        {
            _scanDirection = ScanDirection.Up;
            ScannerPosition = 0;
        }
    }
}