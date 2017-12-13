using AdventOfCode.Day13;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day13
{
    [TestFixture]
    public class SecurityScannerTraversalTests
    {
        private SecurityScannerTraveller _systemUnderTest;
        private SecurityScanner _model;

        [Test]
        public void InitialState_CurrentPositionNegOne()
        {
            _model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            _systemUnderTest = new SecurityScannerTraveller(_model);
            Assert.AreEqual(-1, _systemUnderTest.CurrentPosition);
        }
        [Test]
        public void Step_CurrentPositionIncreases()
        {
            _model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            _systemUnderTest = new SecurityScannerTraveller(_model);
            _systemUnderTest.Advance();
            Assert.AreEqual(0,_systemUnderTest.CurrentPosition);
        }

        [Test]
        public void Step_ReturnsPenaltyIfCaught()
        {
            _model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            _systemUnderTest = new SecurityScannerTraveller(_model);
            _systemUnderTest.CurrentPosition = 3;
            var penalty = _systemUnderTest.Advance();

            Assert.AreEqual(16, penalty);
        }

        [Test]
        public void IsFinished_CurrentPositionPastLayers_ReturnsTrue()
        {
            _model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            _systemUnderTest = new SecurityScannerTraveller(_model);
            _systemUnderTest.CurrentPosition = 7;
            Assert.IsTrue(_systemUnderTest.IsFinished());
        }

        [Test]
        public void MoveToEnd_ReturnsExpectedPenalty()
        {
            _model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            _systemUnderTest = new SecurityScannerTraveller(_model);
            Assert.AreEqual(24,_systemUnderTest.MoveToEnd());
        }
    }
}