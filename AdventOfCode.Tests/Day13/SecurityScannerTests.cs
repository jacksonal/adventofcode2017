using System.Linq;
using AdventOfCode.Day13;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day13
{
    [TestFixture]
    public class SecurityScannerTests
    {
        [Test]
        public void CreateModel_CreatesRightNumberOfLayers()
        {
            var model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            Assert.AreEqual(7, model.Layers.Count);
        }
        [Test]
        public void CreateModel_LayersHaveCorrectScanRange()
        {
            var model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            Assert.AreEqual(3, model.Layers[0].ScanRange);
            Assert.AreEqual(2, model.Layers[1].ScanRange);
            Assert.AreEqual(null, model.Layers[2].ScanRange);
            Assert.AreEqual(null, model.Layers[3].ScanRange);
            Assert.AreEqual(4, model.Layers[4].ScanRange);
            Assert.AreEqual(null, model.Layers[5].ScanRange);
            Assert.AreEqual(4, model.Layers[6].ScanRange);
        }

        [Test]
        public void ScannerLocation_Initially0IfRangeGreaterThan0()
        {
            var model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            foreach (var layer in model.Layers.Where(l=>l.ScanRange>0))
            {
                Assert.AreEqual(0, layer.ScannerPosition);
            }

            foreach (var layer in model.Layers.Where(l => l.ScanRange == 0))
            {
                Assert.IsNull(layer.ScannerPosition);
            }
        }

        [Test]
        public void Step_ScannersAdvance1()
        {
            var model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            model.Step();
            Assert.AreEqual(1,model.Layers[0].ScannerPosition);
            Assert.AreEqual(1, model.Layers[1].ScannerPosition);
            Assert.AreEqual(1, model.Layers[4].ScannerPosition);
            Assert.AreEqual(1, model.Layers[6].ScannerPosition);
        }

        [Test]
        public void Step2_ScannersAdvance2()
        {
            var model = SecurityScanner.CreateModel(Resources.ExampleSecurityScanner);
            model.Step();
            model.Step();
            Assert.AreEqual(2, model.Layers[0].ScannerPosition);
            Assert.AreEqual(0, model.Layers[1].ScannerPosition);
            Assert.AreEqual(2, model.Layers[4].ScannerPosition);
            Assert.AreEqual(2, model.Layers[6].ScannerPosition);
        }
    }
}