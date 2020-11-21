using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zombie_Killer;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        //Since Form1 run the game in private methods. The testing is just for the initial state.
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

        [TestMethod]
        public void TestInitialLevel()
        {
            Form1 form1 = new Form1();
            int expected = 1;
            Assert.AreEqual(expected, form1.Get_Level());
        }

        [TestMethod]
        public void TestGrenadeCollectionStatus()
        {
            Form1 form1 = new Form1();
            bool expected = false;
            Assert.AreEqual(expected, form1.Get_GrenadeCollection());
        }

        [TestMethod]
        public void TestTempScore()
        {
            Form1 form1 = new Form1();
            int expected = 0;
            Assert.AreEqual(expected, form1.Get_TempScore());
        }
    }
}
