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
        public void TestCurrentLevel()
        {
            Form1 form1 = new Form1();
            int expected = 1;
            Assert.AreEqual(expected, form1.Get_Level());

            //level not affected if mark does not reach
            form1.Set_TempScore(9);
            form1.TestLevelIncease();
            expected = 1;
            Assert.AreEqual(expected, form1.Get_Level());

            //increase level after reaching 10 marks
            form1.Set_TempScore(10);
            form1.TestLevelIncease();
            expected = 2;
            Assert.AreEqual(expected, form1.Get_Level());
        }

        [TestMethod] 
        public void TestZombieCountForDifferentLevel()
        {
            Form1 form1 = new Form1();
            int expected = 3;
            Assert.AreEqual(expected, form1.Get_ZombieCount());

            //zombie number increase by 1 after level increase
            form1.Set_TempScore(10);
            form1.TestLevelIncease();
            expected = 4;
            Assert.AreEqual(expected, form1.Get_ZombieCount());
        }

        [TestMethod]
        public void TestCurrentTempScore()
        {
            //temp score will clear to 0 when level increase
            Form1 form1 = new Form1();
            int expected = 0;
            Assert.AreEqual(expected, form1.Get_TempScore());

            //temp score will clear to 0 when level increase
            form1.Set_TempScore(10);
            expected = 10;
            Assert.AreEqual(expected, form1.Get_TempScore());
            form1.TestLevelIncease();
            expected = 0;
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
