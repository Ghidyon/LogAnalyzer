using NUnit.Framework;
using System;

namespace LogAndNotification.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        private LogAnalyzer _analyzer = null;

        [SetUp]
        public void Setup()
        {
            _analyzer = new LogAnalyzer();
        }

        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.slf", true)]
        [TestCase("unexpectedly.foo", false)]
        public void IsValidLogFileName_ValidExtensions_ChecksThem(string fileName, bool expected)
        {
            //Act
            bool result = _analyzer.IsValidLogFileName(fileName);

            //Assert
            Assert.AreEqual(expected, result);
        }

    }
}
