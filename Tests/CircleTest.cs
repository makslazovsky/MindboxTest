using MindboxTest.Figures;
using NUnit.Framework;

namespace Test
{
    public class CircleTest
    {
        [Test]
        public void CircleNegativeRadiusShouldThrowError()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void CircleSquareCalculate()
        {
            var circle = new Circle(10);

            Assert.AreEqual(314.15926535897933d, circle.CalcSquare());
        }
    }
}