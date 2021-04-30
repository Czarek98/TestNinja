using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(301)]
        [TestCase(-1)]
        public void CalculateDemeritPoints_CrossMaxSpeedOrSppedEqualsZero_ThrowArgumentOutOfRangeException(int number)
        {
            var speed = new DemeritPointsCalculator();
            //var result = speed.CalculateDemeritPoints(number);

            Assert.That(()=>speed.CalculateDemeritPoints(number), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(65)]
        [TestCase(60)]
        public void CalculateDemeritPoints_SpeedSmallerOrEqualToSpeedLimit_ReturnZero(int number)
        {
            var speed = new DemeritPointsCalculator();
            var result = speed.CalculateDemeritPoints(number);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedSmallerOrEqualToSpeedLimit_ReturndemeritPoints()
        {
            var speed = new DemeritPointsCalculator();
            var result = speed.CalculateDemeritPoints(80);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}