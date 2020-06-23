using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoverletIssue;

namespace CoverletIssueUnitTests
{
    [TestClass]
    public class CoverletIssueTests
    {
        [TestMethod]
        public void Reproduce_Test()
        {
            Assert.IsTrue(CoverletTesting.Reproduce());
        }
    }
}