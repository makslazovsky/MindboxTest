using MindboxTest.Figures;
using NUnit.Framework;

namespace Test
{
    public class TriangleTest
    {
        [Test]
        public void TriangleCheckRightAngle()
        {
            var triangle = new Triangle(3,4,5);

            Assert.AreEqual(true, triangle.IsRightAngle);
        }

        [Test]
        public void TriangleCheckRightAngleShouldBeNegative()
        {
            var triangle = new Triangle(3,7,7);

            Assert.AreEqual(false, triangle.IsRightAngle);
        }

        [Test]
        public void TriangleCheckExists()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(3, 7, -7));
        }

        [Test]
        public void TriangleCheckCorrectSquare()
        {
            var triangle = new Triangle(3,4,5);

            Assert.AreEqual(6, triangle.CalcSquare());
        }
    }
}
