using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zombie_Killer;
using System;
using System.Windows.Forms;
using System.Collections.Generic;


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
            form1.TestAmmoReduce(2);
            expected = 8;
            Assert.AreEqual(expected, form1.Get_Ammo());
        }

        [TestMethod]
        public void TestPlayerHP()
        {
            Form1 form1 = new Form1();
            int expected = 100;
            form1.TestHpReduce(30);
            expected = 70;
            Assert.AreEqual(expected, form1.Get_HP());
        }

        [TestMethod]
        public void TestZombieCount()
        {
            Form1 form1 = new Form1();
            int expected = 3;
            form1.TestZombieIncrease(3);
            expected = 6;
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

        [TestMethod]
        public void TestShieldList()
        {
            // The purpose of this test is to ensure that the List containing the Shield PictureBox 
            // at the start of the program should be empty
            Form1 form1 = new Form1();
            int expected = 0;
            Assert.AreEqual(expected, form1.Get_ListOfShield().Count);
        }

        [TestMethod]
        public void TestNumberOfGun()
        {
            Form1 form1 = new Form1();
            form1.testCollectGun("SuperGun");
            form1.testCollectGun("LaserGun");
            int expected = 2;
            Assert.AreEqual(expected, form1.getNumberOfGunCollected());
        }

        [TestMethod]
        public void TestDropSuperGun()
        {
            Form1 form1 = new Form1();
            form1.DropSuperGun();
            bool expected = true;
            Assert.AreEqual(expected, form1.dropSuperGun);
        }

        [TestMethod]
        public void TestDropLaserGun()
        {
            Form1 form1 = new Form1();
            form1.DropLaserGun();
            bool expected = true;
            Assert.AreEqual(expected, form1.dropLaserGun);
        }
    }
}
