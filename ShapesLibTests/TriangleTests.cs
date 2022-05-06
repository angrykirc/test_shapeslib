using System;
using Xunit;
using ShapesLib;

namespace ShapesLibTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 8, 8)]
        [InlineData(3, 9, 9)]
        public void TestTriangleValid(int a, int b, int c)
        {
            var t = new ShapeTriangle(a, b, c);
            Assert.True(t.IsValid());
        }
        
        [Fact]
        public void TestTriangleNotValid()
        {
            var t = new ShapeTriangle(3, 2, 6);
            Assert.False(t.IsValid());
        }
    }
}