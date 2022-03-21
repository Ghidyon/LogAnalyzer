using NUnit.Framework;
using System;

namespace LogAndNotification.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.slf", true)]
        [TestCase("unexpectedly.foo", false)]
        public void IsValidLogFileName_ValidExtensions_ChecksThem(string fileName, bool expected)
        {
            // Arrange
            LogAnalyzer logAnalyzer = new LogAnalyzer();

            //Act
            bool result = logAnalyzer.IsValidLogFileName(fileName);

            //Assert
            Assert.AreEqual(expected, result);
        }

    }
}
