using System.Linq;
using AdventOfCode.Day8;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day8
{
    [TestFixture]
    public class ValueTableTests
    {
        private ValueTable _systemUnderTest;

        [Test]
        public void Lookup_NotInTable_ReturnsZero()
        {
            _systemUnderTest = new ValueTable();
            Assert.AreEqual(0,_systemUnderTest.LookUp("a"));
        }
        [Test]
        public void Update_SetsValue()
        {
            _systemUnderTest = new ValueTable();
            _systemUnderTest.Update("a", 5);
            Assert.AreEqual(5, _systemUnderTest.LookUp("a"));
        }
    }
}