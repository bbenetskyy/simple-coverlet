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

        [Fact]
        public void TestSub()
        {
            Math.Sub(5, 3).Should().Be(2);
            Math.Sub(5, 0).Should().Be(0);
        }

        [Fact]
        public void TestMul()
        {
            Math.Mul(5, 5).Should().Be(25);
        }

        [Fact]
        public void TestDiv()
        {
            Math.Div(5, 5).Should().Be(1);
        }
    }
}
