using AdventOfCode.Day13;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day13
{
    [TestFixture]
    public class DelayedSecurityScannerTraversalTests
    {
        private DelayedSecurityScannerTraveller _systemUnderTest;

        [Test]
        public void GetDelayForSafePassage_CorrectForTestInput()
        {
            var model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            _systemUnderTest = new DelayedSecurityScannerTraveller(model);
            Assert.AreEqual(10, _systemUnderTest.GetDelayForSafePassage());
        }
    }
}