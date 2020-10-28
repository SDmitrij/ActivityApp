using ActivityApp.User;
using ActivityApp.User.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ActivityAppUnit.User
{
    [TestClass]
    public class CreatorTest
    {
        [TestMethod]
        public void TestHwolUserCreation()
        {
            var user = Creator.Create(typeof(Hwol).AssemblyQualifiedName);
            Assert.AreEqual(true, user is Hwol, "Hwol user creation failed!");
        }

        [TestMethod]
        public void TestNonHwolUserCreation()
        {
            var user = Creator.Create(typeof(NonHwol).AssemblyQualifiedName);
            Assert.AreEqual(true, user is NonHwol, "Non hwol user creation failed!");
        }

        [TestMethod]
        public void TestSemiHwolUserCreation()
        {
            var user = Creator.Create(typeof(SemiHwol).AssemblyQualifiedName);
            Assert.AreEqual(true, user is SemiHwol, "Semihwol user creation failed!");
        }
    }
}
