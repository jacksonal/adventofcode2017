using AdventOfCode.Day13;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day13
{
    public class LayerTests
    {
        [Test]
        public void ScannerAtZero_BeforeStepping_ReturnsFalse()
        {
            var layer = new FireWallLayer();
            layer.ScanRange = 2;
            Assert.IsTrue(layer.ScannerAtZero(0));
        }

        [TestCase(1, false)]
        [TestCase(2, false)]
        [TestCase(3, false)]
        [TestCase(4, true)]
        public void ScannerAtZero_AfterStepping_ReturnsExpectedResult(int step, bool expected)
        {
            var layer = new FireWallLayer();
            layer.ScanRange = 3;
            Assert.AreEqual(expected, layer.ScannerAtZero(step));
        }
    }
}