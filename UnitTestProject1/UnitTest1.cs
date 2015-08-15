using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void stringZip()
        {
            string before = "宁波华晟";
            string tmp=OrderSheetCreator.PublicTools.stringZip(before);
            Assert.AreEqual(tmp, "华晟", "not ok");

        }

        [TestMethod]
        public void GetCellIntFromChar()
        {
            int tmp = OrderSheetCreator.PublicTools.GetCellIntFromChar('A');
            Assert.AreEqual(tmp, 1, "not ok");

        }
    }
}
