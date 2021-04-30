using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FomatAsBold_WhenCalled_ReturnStringStrong()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("abc");

            //Specific - better in this case
            //ctrl k ctrl c - komentowanie
            //ctrl k ctrl u - odkomentowanie
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));


            //too general 
            //Assert.That(result, Does.StartWith("<strong>"));
            //Assert.That(result, Does.EndWith("</strong>"));
            //Assert.That(result, Does.Contain("abc"));
        }
    }
}
