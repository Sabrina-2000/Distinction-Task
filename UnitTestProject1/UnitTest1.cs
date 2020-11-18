using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zombie_Killer;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAmmoCount()
        {
            Form1 form1 = new Form1();
            int expected = 10;
            Assert.AreEqual(expected, form1.Get_Ammo());
        }

        [TestMethod]
        public void TestPlayerHP()
        {
            Form1 form1 = new Form1();
            int expected = 100;
            Assert.AreEqual(expected, form1.Get_HP());
        }

        [TestMethod]
        public void TestZombieCount()
        {
            Form1 form1 = new Form1();
            int expected = 3;
            Assert.AreEqual(expected, form1.Get_ZombieCount());
        }
    }
}
