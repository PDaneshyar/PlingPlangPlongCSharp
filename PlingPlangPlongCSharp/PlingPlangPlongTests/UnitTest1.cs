using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlingPlangPlongCSharp;

namespace PlingPlangPlongTests
{
    [TestClass]
    public class UnitTest1
    {
        // these tests will check the function works for all correct scenarios

        [TestMethod]
        public void TestFactor3()
        {
            // running multiple tests for clarity
            Assert.AreEqual(Program.PlingPlangPlong(3), "Pling");
            Assert.AreEqual(Program.PlingPlangPlong(9), "Pling");
        }

        [TestMethod]
        public void TestFactor5()
        {
            Assert.AreEqual(Program.PlingPlangPlong(5), "Plang");
            Assert.AreEqual(Program.PlingPlangPlong(10), "Pling");
        }

        [TestMethod]
        public void TestFactor7()
        {
            Assert.AreEqual(Program.PlingPlangPlong(7), "Plong");
            Assert.AreEqual(Program.PlingPlangPlong(14), "Pling");
        }

        [TestMethod]
        public void TestMultipleFactors()
        {
            Assert.AreEqual(Program.PlingPlangPlong(105), "PlingPlangPlong");
            Assert.AreEqual(Program.PlingPlangPlong(15), "PlingPlang");
        }

        [TestMethod]
        public void TestNegatives()
        {
            Assert.AreEqual(Program.PlingPlangPlong(-3), "Pling");
            Assert.AreEqual(Program.PlingPlangPlong(-12), "Pling");
        }

    }
}
