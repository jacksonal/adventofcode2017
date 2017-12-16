﻿using System.Collections.Generic;
using AdventOfCode.Day16;
using NUnit.Framework;

namespace AdventOfCode.Tests.Day16
{
    [TestFixture]
    public class DanceLineTests
    {
        [Test]
        public void Solve_ExampleCase()
        {
            var line = new TestDanceLine();
            var result = line.Solve("s1,x3/4,pe/b");
            Assert.AreEqual("baedc", result);
        }
    }

    public class TestDanceLine : DanceLine
    {
        public TestDanceLine()
        {
            _dancers = new List<char>{'a', 'b', 'c', 'd', 'e'};
        }
    }
}