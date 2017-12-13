using System.Linq;

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
            while (_scanner.Layers.Aggregate(false, (result, layer) => result || layer.ScannerAtZero(delay + _scanner.Layers.IndexOf(layer))))
            {
                delay++;
            }
            return delay;
        }

        public override bool IsFinished()
        {
            return base.IsFinished() || IsCaught;
        }
    }
}