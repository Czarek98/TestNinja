

using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");
            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("    ")]
        public void Log_IsNullOrWhiteSpace_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            //logger.Log(error); niepoprawne bo by sie program wysypał 
            Assert.That(()=> logger.Log(error), Throws.ArgumentNullException);
           //Gdyby typu wyjatku nie bylo na liscie
           //Assert.That(()=> logger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());
        }

    }
}
