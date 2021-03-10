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
            DateTime Birthday = new DateTime(1999, 12, 31);
            Person Me = new Person("Stavros", "Fakiolas", "fakiolass@stpaulsschool.org.uk", Birthday);

            Assert.AreEqual(22, Me.ComputeAge(Me));     // How to take in old instance
            Assert.IsTrue();
        }
    }
}
