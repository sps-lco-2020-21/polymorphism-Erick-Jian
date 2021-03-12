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
            Person MeClone = Me;

            Assert.AreEqual(22, Me.ComputeAge(MeClone.));     // How to take in old instance
            Assert.IsTrue(Me.Zodiac() == "申"); 
        }
    }
}
