namespace AdventOfCode.Day13
{
    public class DelayedSecurityScannerTraveller : SecurityScannerTraveller
    {

        public DelayedSecurityScannerTraveller(SecurityScanner model) : base(model)
        {
        }

        public int GetDelayForSafePassage()
        {
            var delay = 0;
            MoveToEnd();
            while (IsCaught)
            {
                _scanner.Reset();
                Reset();
                delay++;
                for (var i = 0; i < delay; i++)
                {
                    _scanner.Step();
                }
                MoveToEnd();
            }
            return delay;
        }

        public override bool IsFinished()
        {
            return base.IsFinished() || IsCaught;
        }
    }
}