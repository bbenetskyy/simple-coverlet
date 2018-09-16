using System;
using Xunit;
using Math = src.lib.Math;
using FluentAssertions;

namespace src.tests
{
    public class MathTests
    {
        [Fact]
        public void TestAdd()
        {
            Math.Add(2, 3).Should().Be(5);
        }
    }
}
