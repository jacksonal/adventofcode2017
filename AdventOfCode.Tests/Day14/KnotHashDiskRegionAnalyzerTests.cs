using AdventOfCode.Day14;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day14
{
    [TestFixture]
    public class KnotHashDiskRegionAnalyzerTests
    {
        private KnotHashDiskRegionAnalyzer _systemUnderTest;
        [Test]
        public void ExampleTestCase()
        {
            _systemUnderTest = new KnotHashDiskRegionAnalyzer();
            Assert.AreEqual(1242,_systemUnderTest.Solve("flqrgnkx"));
        }
    }
}