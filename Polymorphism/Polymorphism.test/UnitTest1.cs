using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualNewOverride;

namespace Polymorphism.test
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void TestComputeAge()
        {
            DateTime Birthday = new DateTime(2004, 3, 16);
            Person Me = new Person("Stavros", "Fakiolas", "fakiolass@stpaulsschool.org.uk", Birthday);

            Assert.AreEqual(27, Me.ComputeAge());     // How to take in old instance
            Assert.IsTrue(Me.ChineseZodiac() == "申");
            Assert.IsFalse(Me.IsOverAge());
                }
    }
}
