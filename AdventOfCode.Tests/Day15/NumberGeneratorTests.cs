using AdventOfCode.Day15;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day15
{
    public class NumberGeneratorTests
    {
        [TestCase(1, 1092455)]
        [TestCase(2, 1181022009)]
        [TestCase(3, 245556042)]
        [TestCase(4, 1744312007)]
        [TestCase(5, 1352636452)]
        public void AGeneratesCorrectNextNumber(int quantity, long expected)
        {
            var numberGen = new NumberGenerator(16807, 65);
            for (int i = 0; i < quantity - 1; i++)
            {
                numberGen.Next().Wait();
            }
            var task = numberGen.Next();
            task.Wait();
            Assert.AreEqual(expected,task.Result);
        }

        [TestCase(1, 430625591)]
        [TestCase(2, 1233683848)]
        [TestCase(3, 1431495498)]
        [TestCase(4, 137874439)]
        [TestCase(5, 285222916)]
        public void BGeneratesCorrectNextNumber(int quantity, long expected)
        {
            var numberGen = new NumberGenerator(48271, 8921);
            for (int i = 0; i < quantity - 1; i++)
            {
                numberGen.Next().Wait();
            }
            var task = numberGen.Next();
            task.Wait();
            Assert.AreEqual(expected, task.Result);
        }
    }
}