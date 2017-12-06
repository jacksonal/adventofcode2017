using System.Collections.Generic;
using AdventOfCode.Day6;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day6
{
    [TestFixture]
    public class MemoryAllocationTests
    {
        private MemoryAllocation _systemUnderTest;
        private List<int> _memBucketInput;

        [SetUp]
        public void BeforeEach()
        {
            _memBucketInput = new List<int> {0, 2, 7, 0};
            _systemUnderTest = new MemoryAllocation(_memBucketInput);
        }

        [Test]
        public void CreateMemoryAllocation_GivenListOfIntegers_AllocationStored()
        {
            for (var i = 0; i < _memBucketInput.Count; i++)
            {
                var bucket = _memBucketInput[i];
                Assert.AreEqual(bucket, _systemUnderTest.Buckets[i]);
            }
        }

        [Test]
        public void Reallocate_RedistributesBiggestBucket()
        {
            _systemUnderTest.Reallocate();
            Assert.AreEqual(2, _systemUnderTest.Buckets[0]);
            Assert.AreEqual(4, _systemUnderTest.Buckets[1]);
            Assert.AreEqual(1, _systemUnderTest.Buckets[2]);
            Assert.AreEqual(2, _systemUnderTest.Buckets[3]);
        }

        [Test]
        public void Reallocate_TieForBiggest_FirstBucketUsed()
        {
            _systemUnderTest = new MemoryAllocation(new List<int>{3, 1, 2, 3});
            _systemUnderTest.Reallocate();
            Assert.AreEqual(0, _systemUnderTest.Buckets[0]);
            Assert.AreEqual(2, _systemUnderTest.Buckets[1]);
            Assert.AreEqual(3, _systemUnderTest.Buckets[2]);
            Assert.AreEqual(4, _systemUnderTest.Buckets[3]);
        }
    }
}