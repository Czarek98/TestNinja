using NUnit.Framework;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Math _math;

        //SetUp - na początku
        //TearDown - na końcu
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
       // [Ignore("I'll do it tomorrow")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5); // 1,3,5

            //Asserty pomocnicze - nie wykorzsytywać w tym przypadku

            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            //Assert.That(result, Is.Unique);
            //Assert.That(result, Is.Ordered);


            //Poprawny Assert

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));


        }
    }
}
