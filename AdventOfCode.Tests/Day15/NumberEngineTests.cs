using System.CodeDom;
using AdventOfCode.Day15;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day15
{
    public class NumberEngineTests
    {
        [Test]
        public void EngineWithNoFilter_FindsMatchAfter3Iterations()
        {
            var engine = new NumberEngineAsync(65, 8921);
            Assert.AreEqual(1,engine.GetCountOfValidNumbersGenerated(3));
            Assert.AreEqual(1, engine.GetCountOfValidNumbersGeneratedAsync(3));
        }

        [Test]
        public void EngineWithFilter_FindsMatchAfter1056Iterations()
        {
            var engine = new NumberEngineAsync(65, 8921, 4, 8);
            Assert.AreEqual(1, engine.GetCountOfValidNumbersGenerated(1056));
            Assert.AreEqual(1, engine.GetCountOfValidNumbersGeneratedAsync(1056));
        }
    }
}