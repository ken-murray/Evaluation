using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileData.IntegrationTests
{
    // Ken Murray - technical project assessment

    [TestClass]
    public class FileDetailsTests
    {
        [TestMethod]
        public void IsVersion_WithFirstParameter_ReturnsVersion()
        {
            Assert.IsTrue(Program.IsVersion("-v") && Program.IsVersion("--v") && Program.IsVersion("/v") && Program.IsVersion("--version"));
        }

        [TestMethod]
        public void IsSize_WithFirstParameter_ReturnsVersion()
        {
            Assert.IsTrue(Program.IsSize("-s") && Program.IsSize("--s") && Program.IsSize("/s") && Program.IsSize("--size"));
        }
    }
}
