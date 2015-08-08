using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string before = "宁波华晟";
            string tmp=OrderSheetCreator.PublicTools.stringZip(before);
            Assert.AreEqual(tmp, "华晟", "not ok");

        }
    }
}
