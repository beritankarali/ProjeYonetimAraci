using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazılımSınamaProje;

namespace YazilimTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ytesti test11 = new ytesti();
        }
        [TestMethod]
        public void kullanicigiriş()
        {
            ytesti test1 = new ytesti();
            int i= test1.kullanıcıgirişikontrol("BeritanKarali", "3535");
            Assert.AreEqual(3535, i);
        }

        [TestMethod]
        public void TestMethod2()
        {
            yazilimtesti test2 = new yazilimtesti();
        }

        [TestMethod]
        public void musterigiris()
        {
            yazilimtesti test2 = new yazilimtesti();
            int m = test2.musterigirisikontrol("MerveAltili", "mervealtili");
            Assert.AreEqual("mervealtili", m);
        }
      
    }
}
