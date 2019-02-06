using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ThirdPartyTools.UnitTests
{
    [TestClass]
    public class FileDetailsTests
    {
        // Ken Murray - technical project assessment

        [TestMethod]
        public void Version_WithFilename_ReturnsTwoDots()
        {
            var fileDetails = new FileDetails();

            var result = fileDetails.Version("c:/test.txt");

            string[] versionNumbers = result.Split('.');

            Assert.IsTrue(versionNumbers.Length == 3);
        }

        [TestMethod]
        public void Version_WithFilename_ReturnsThreeNumbers()
        {
            var fileDetails = new FileDetails();

            var result = fileDetails.Version("c:/test.txt");

            string[] versionNumbers = result.Split('.');

            Assert.IsTrue(versionNumbers.Length == 3 && versionNumbers[0].All(char.IsDigit) && versionNumbers[1].All(char.IsDigit) && versionNumbers[2].All(char.IsDigit));
        }

        [TestMethod]
        public void Size_WithFilename_ReturnsIntegerWithinRange()
        {
            var fileDetails = new FileDetails();

            var result = fileDetails.Size("c:/test.txt");

            Assert.IsTrue(result >= 100000 && result < 200000);
        }
    }

    //Note: not testing FileDates as it hasn't been fully implemented
}