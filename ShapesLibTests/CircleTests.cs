using Xunit;
using ShapesLib;

namespace ShapesLibTests
{
    public class CircleTests
    {
        [Fact]
        public void TestCircleValid()
        {
            var c = new ShapeCircle(1);
            Assert.True(c.IsValid());
        }
        
        [Fact]
        public void TestCircleNotValid()
        {
            var c = new ShapeCircle(-1);
            Assert.False(c.IsValid());
        }
    }
}