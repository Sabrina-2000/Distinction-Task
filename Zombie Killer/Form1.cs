﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Zombie_Killer
{
    public partial class Form1 : Form
    {

        // start the variables

        bool goup;                                              // this boolean will be used for the player to go up the screen
        bool godown;                                            // this boolean will be used for the player to go down the screen
        bool goleft;                                            // this boolean will be used for the player to go left to the screen
        bool goright;                                           // this boolean will be used for the player to right to the screen
        string facing = "up";                                   // this string is called facing and it will be used to guide the bullets
        int playerHealth = 100;                                 // this double vaiable is called player health
        int playerShield = 0;                                   // This is the variable for storing the player's shield value

        int speed = 10;                                         // this interget is for the speed of the player
        int ammo = 10;                                          // this integer will hold the number of ammo the player has start of the game
        int zombieSpeed = 3;                                    // this integer will hold the speed which the zombies move in the game
        int score = 0;                                          // this integer will hold the score the player achieved through the game
        bool gameOver = false;                                  // this boolean is false in the beginning and it will be used when the game is finished
        string typeOfGun = "";
        Random rnd = new Random();                              // this is an instance of the random class we will use this to create a random number for this game
        string path = "../../Text/Scoreboard.txt";              //The path of the Scoreboard.txt
        string path2 = "../../Text/date.txt";                   //The path of the date.txt
        bool isGrenadeCollected = false;                        //this boolean is false initially until the player collect the grenade
        int distance = 300;                                     //distance of throwing
        int explosionTime = 0;
        int level = 1;                                          //this integer will hold the level the player is at
        int tempScore = 0;                                      // this integer will hold the score the player in each level and clear the value after level up

        List<PictureBox> zombiesList = new List<PictureBox>();  // list to store the zombie
        List<PictureBox> medicList = new List<PictureBox>();    // list to store the medic
        List<PictureBox> gunList = new List<PictureBox>();      // list to store the gun
        List<PictureBox> shieldList = new List<PictureBox>();   // list to store the shield
        List<PictureBox> grenadeList = new List<PictureBox>();   // list to store the grenade

        Inventory inventory = new Inventory();
        Gun guns = new Gun();
        public bool dropSuperGun = false;
        public bool dropLaserGun = false;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MedicTimerEvent(object sender, EventArgs e)
        {   // drop the medic after every 10 seconds
            DropMedic();
        }

        private void SuperGunTimerEvent(object sender, EventArgs e)
        {   // drop the gun after every 20 seconds
            DropSuperGun();
            SuperGunTimer.Enabled = false;
        }

        private void LaserGunTimerEvent(object sender, EventArgs e)
        {   // drop the gun after 30 seconds
            DropLaserGun();
            LaserGunTimer.Enabled = false;
        }

        private void ShieldTimerEvent(object sender, EventArgs e)
        {
            // Drop the shield after 35 seconds
            DropShield();
        }

        private void GrenadeTimerEvent(object sender, EventArgs e)
        {
            DropGrenade();
            GrenadeTimer.Enabled = false;
        }

        private void explosionTimerEvent(object sender, EventArgs e)
        {
            explosionTime++;
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            // These if-else statement is for checking whether the player's health and shield value is equal to zero
            // If it is true then end the game
            if (playerHealth > 1 && playerShield >= 0)
            {
                healthBar.Value = playerHealth;
                shieldBar.Value = playerShield;
            }
            else
            {
                gameOver = true;


                // This if-else statements are for to display the character based on the chosen character by the user
                // The default value of choseCharacter variable is man character 
                if (ChooseCharacter.chosenCharacter == "woman")
                {
                    player.Image = Properties.Resources.p2_death;
                }
                else
                {
                    player.Image = Properties.Resources.death;
                }
                
                GameTimer.Stop();
                MedicTimer.Stop();
                SuperGunTimer.Stop();
                LaserGunTimer.Stop();
                shieldTimer.Stop();
                GrenadeTimer.Stop();

                StreamWriter sw = File.AppendText(path);
                sw.WriteLine("Kills: " + score.ToString());
                sw.Close();

                DateTime thisDay = DateTime.Now;
                StreamWriter dt = File.AppendText(path2);
                dt.WriteLine(thisDay.ToString());
                dt.Close();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;
            txtLevel.Text = "Level " + level;

            if (tempScore == 10)
            {  //level up condition
                level++;
                tempScore = 0;
                MakeZombies(); // create the new zombie to the list
            }

            if (goleft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if(goright == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if(goup == true && player.Top > 75)
            {
                player.Top -= speed;
            }

            if(godown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo") 
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player intersects with ammo
                    {
                        SoundPlayer reload = new SoundPlayer("../../Sound/reload.wav");
                        reload.Play(); // play reload sound effect
                        this.Controls.Remove(x); // remove the ammo on screen
                        ((PictureBox)x).Dispose(); // dispose the picture box
                        ammo += 5; // add the ammo to 5
                    }
                }

                if (x is PictureBox && (string)x.Tag == "medic")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player intersects with medic 
                    {
                        SoundPlayer pickMedic = new SoundPlayer("../../Sound/pickMedic.wav");
                        pickMedic.Play(); // play the pickMedic sound effect
                        this.Controls.Remove(x); // remove the medic on screen
                        medicList.Remove((PictureBox)x); // remove the medic from the medic list
                        ((PictureBox)x).Dispose(); // dispose the picture box
                        if ((playerHealth + 30) <= 100)
                        {
                            playerHealth += 30; // increase the player health by 30
                        }
                        else
                        {
                            playerHealth = 100; // if the player's health + 30 is greater than 100, player' health = 100
                        }
                    }
                }

                if (x is PictureBox && (string)x.Tag == "superGun")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player intersects with the superGun
                    {
                        this.Controls.Remove(x); // remove the gun on screen
                        ((PictureBox)x).Dispose(); // dispose the picture box
                        inventory.collectItem("SuperGun");// get super gun
                        superGun.Image = Properties.Resources.SuperGun;
                        LaserGunTimer.Enabled = true;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "laserGun")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player intersects with laserGun 
                    {
                        this.Controls.Remove(x); // remove the gun on screen
                        ((PictureBox)x).Dispose(); // dispose the picture box
                        inventory.collectItem("LaserGun");// get laser gun
                        laserGun.Image = Properties.Resources.LaserGun;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "shieldIcon")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) // If the player intersects with the shield
                    {
                        SoundPlayer pickMedic = new SoundPlayer("../../Sound/pickMedic.wav");
                        pickMedic.Play(); // play the pickMedic sound
                        this.Controls.Remove(x);                // Remove the shield on the screen
                        ((PictureBox)x).Dispose();              // Dispose the picture box
                        playerShield = 100;                     // If the player grab the shield then it will restore the player's shield until full
                    }
                }

                if (x is PictureBox && (string)x.Tag == "grenades")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player intersects with grenade 
                    {
                        this.Controls.Remove(x); // remove the grenade on screen
                        grenadeList.Remove((PictureBox)x); // remove the medic from the grenade list
                        ((PictureBox)x).Dispose(); // dispose the picture box
                        inventory.collectItem("Grenades");// get grenades
                        grenade.Image = Properties.Resources.grenade;
                        grenade.Visible = true;
                        isGrenadeCollected = true;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player's intersects with zombie
                    {
                        // If the value of player's shield is still more than 0 thus decrease the shield's value before reducing the player's health
                        if (playerShield > 0)
                        {
                            playerShield -= 1;
                        }
                        else
                        {
                            playerHealth -= 1; //player's health minus by 1
                            if((playerHealth - 1) == 0) //if player's heath minus 1 is equal 0, player's health equal 0
                            {
                                playerHealth = 0;
                            }
                        }
                    }
                    // let the zombies chase the player
                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in this.Controls)
                {  
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds)) // if bullets are intersect with zombies
                        {
                            score++; // score plus 1
                            tempScore++;
                            this.Controls.Remove(j); // remove the bullets on screen
                            ((PictureBox)j).Dispose(); // dispose the picture box
                            this.Controls.Remove(x); // remove the zombie on screen
                            ((PictureBox)x).Dispose(); // dispose the picture box
                            zombiesList.Remove(((PictureBox)x)); // remove the zombie from the list
                            MakeZombies(); // create the zombies
                        }
                    }
                }

                //throw grenade
                foreach (Control k in this.Controls)
                {
                    if (k is PictureBox && (string)k.Tag == "explosion" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        Rectangle intersectionArea = Rectangle.Intersect(x.Bounds, k.Bounds);
                        while (intersectionArea.IsEmpty == false) // if grenade range are intersect with zombies
                        {
                            score++; // score plus 1
                            tempScore++;
                            this.Controls.Remove(x); // remove the zombie on screen
                            ((PictureBox)x).Dispose(); // dispose the picture box
                            zombiesList.Remove(((PictureBox)x)); // remove the zombie from the list
                            MakeZombies(); // create the zombies
                            break;
                        }
                        while (intersectionArea.IsEmpty && explosionTime == 1)
                        {
                            this.Controls.Remove(k); // remove the grenade on screen
                            ((PictureBox)k).Dispose(); // dispose the picture box
                            explosionTimer.Stop();
                            explosionTime = 0;
                            break;
                        }
                    }
                }
            }
        }

        public void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

            //select gun by clicking 1,2,3 on the keyboard
            if((e.KeyCode == Keys.D1) && (inventory.numberOfGun()>=1))
            {
                typeOfGun = guns.selectGun(1, inventory);//"SuperGun";
            }

            if ((e.KeyCode == Keys.D2) && (inventory.numberOfGun() >= 2))
            {
                typeOfGun = guns.selectGun(2, inventory);
                //typeOfGun = "LaserGun";
            }

            if ((e.KeyCode == Keys.D3) && (inventory.numberOfGun() >= 3))
            {
                typeOfGun = guns.selectGun(3, inventory);
            }

            //take grenade from inventory and throw grenade
            if ((e.KeyCode == Keys.D4) && (isGrenadeCollected == true))
            {
                explosionTimer.Start();
                grenade.Visible = false;
                GrenadeExplosion(facing);
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                SoundPlayer shoot = new SoundPlayer("../../Sound/gunshot.wav");
                shoot.Play(); // play the shoot sound
                ammo--; // deduct the ammo when player hit space key
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo(); // drop the ammo when ammo is 0
                }
            }

           if (e.KeyCode == Keys.Enter && gameOver == true) // player hits enter key and gameover is true
            {
                RestartGame(); // restart the game
           }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                facing = "left";

                // This if-else statements are for to display the character based on the chosen character by the user
                // The default value of choseCharacter variable is man character 
                if (ChooseCharacter.chosenCharacter == "woman")
                {
                    player.Image = Properties.Resources.p2_left; // player faces left
                }
                else
                {
                    player.Image = Properties.Resources.left; // player faces left
                } 
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                facing = "right";

                // This if-else statements are for to display the character based on the chosen character by the user
                // The default value of choseCharacter variable is man character 
                if (ChooseCharacter.chosenCharacter == "woman")
                {
                    player.Image = Properties.Resources.p2_right; // player faces right
                }
                else
                {
                    player.Image = Properties.Resources.right; // player faces right
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                facing = "up";

                // This if-else statements are for to display the character based on the chosen character by the user
                // The default value of choseCharacter variable is man character 
                if (ChooseCharacter.chosenCharacter == "woman")
                {
                    player.Image = Properties.Resources.p2_up; // player faces up
                }
                else
                {
                    player.Image = Properties.Resources.up; // player faces up
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                facing = "down";

                // This if-else statements are for to display the character based on the chosen character by the user
                // The default value of choseCharacter variable is man character 
                if (ChooseCharacter.chosenCharacter == "woman")
                {
                    player.Image = Properties.Resources.p2_down; // player faces down
                }
                else
                {
                    player.Image = Properties.Resources.down; // player faces down
                }
            }
        }

        private void ShootBullet(string direction)
        {
            bullet shootBullet = new bullet(); // create the bullet
            shootBullet.direction = direction; // set the direction to player's direction
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this,typeOfGun);
        }

        private void GrenadeExplosion(string direction)
        {
            Explosion grenadeExplosion = new Explosion(); // create the explosion
            grenadeExplosion.direction = direction; // set the direction to player's direction
            // if direction equals to left
            if (direction == "left")
            {
                grenadeExplosion.explosionLeft = player.Left + (player.Width / 2) - distance;
                grenadeExplosion.explosionTop = player.Top + (player.Height / 2);
            }
            // if direction equals right
            else if (direction == "right")
            {
                grenadeExplosion.explosionLeft = player.Left + (player.Width / 2) + distance;
                grenadeExplosion.explosionTop = player.Top + (player.Height / 2);
            }
            // if direction is up
            else if (direction == "up")
            {
                grenadeExplosion.explosionLeft = player.Left + (player.Width / 2);
                grenadeExplosion.explosionTop = player.Top + (player.Height / 2) - distance;
            }
            // if direction is down
            else if (direction == "down")
            {
                grenadeExplosion.explosionLeft = player.Left + (player.Width / 2);
                grenadeExplosion.explosionTop = player.Top + (player.Height / 2) + distance;
            }
            grenadeExplosion.MakeExplosion(this);
            isGrenadeCollected = false;
            DropGrenade();
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = rnd.Next(0, 900);
            zombie.Top = rnd.Next(0, 800); 
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie); // add zombies to the list
            this.Controls.Add(zombie); // add zombies to the screen
            player.BringToFront(); // bring the player to the front
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image; 
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = rnd.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo); // add the ammo to the screen
            ammo.BringToFront(); // bring the ammo to the front
            player.BringToFront(); // bring the player to the front
        }

        private void DropMedic()
        {
            PictureBox medic = new PictureBox();
            medic.Image = Properties.Resources.medic;
            medic.SizeMode = PictureBoxSizeMode.AutoSize;
            medic.Left = rnd.Next(15, this.ClientSize.Width - medic.Width);
            medic.Top = rnd.Next(60, this.ClientSize.Height - medic.Height);
            medicList.Add(medic); // add the medic to the list
            medic.Tag = "medic";
            this.Controls.Add(medic); // add the medic to the screen
            medic.BringToFront(); // bring the medic to the front
            player.BringToFront(); // bring the player to the front
        }

        public void DropSuperGun()
        {
            PictureBox superGun = new PictureBox();
           
            superGun.Image = Properties.Resources.SuperGun;
            superGun.SizeMode = PictureBoxSizeMode.AutoSize;
            superGun.Left = rnd.Next(15, this.ClientSize.Width - superGun.Width);
            superGun.Top = rnd.Next(60, this.ClientSize.Height - superGun.Height);
            superGun.Tag = "superGun";
            gunList.Add(superGun);
            this.Controls.Add(superGun); // add the superGun to the screen
            superGun.BringToFront(); // bring the superGun to the front
            player.BringToFront(); // bring the player to the front
            dropSuperGun = true;
        }

        public void DropLaserGun()
        {
            PictureBox laserGun = new PictureBox();
            laserGun.Image = Properties.Resources.LaserGun;
            laserGun.SizeMode = PictureBoxSizeMode.AutoSize;
            laserGun.Left = rnd.Next(15, this.ClientSize.Width - laserGun.Width);
            laserGun.Top = rnd.Next(60, this.ClientSize.Height - laserGun.Height);
            laserGun.Tag = "laserGun";
            gunList.Add(laserGun);
            this.Controls.Add(laserGun); // add the laserGun to the screen
            laserGun.BringToFront(); // bring the laserGun to the front
            player.BringToFront(); // bring the player to the front
            dropLaserGun = true;
        }

        private void DropShield()
        {
            // Create a new PictureBox element to store the shield image
            PictureBox shield = new PictureBox();
            shield.Image = Properties.Resources.shield;

            // Setting the size of the image into an autosize 
            shield.SizeMode = PictureBoxSizeMode.AutoSize;

            // Setting the position based on the Client's width and height
            shield.Left = rnd.Next(15, this.ClientSize.Width - shield.Width);
            shield.Top = rnd.Next(60, this.ClientSize.Height - shield.Height);

            // Giving the image a tag as the identifier
            shield.Tag = "shieldIcon";

            // Add it to the list
            shieldList.Add(shield);

            this.Controls.Add(shield);  // Add the shield to the screen
            shield.BringToFront();      // Bring the shield to the front
            player.BringToFront();      // Bring the player to the front

        }

        private void DropGrenade()
        {
            PictureBox grenade = new PictureBox();
            grenade.Image = Properties.Resources.grenade;
            grenade.SizeMode = PictureBoxSizeMode.AutoSize;
            grenade.Left = rnd.Next(15, this.ClientSize.Width - grenade.Width);
            grenade.Top = rnd.Next(60, this.ClientSize.Height - grenade.Height);
            grenade.Tag = "grenades";
            this.Controls.Add(grenade); // add grenade to the screen
            grenade.BringToFront(); // bring grenade to the front
            player.BringToFront(); // bring the player to the front
        }

        private void RestartGame()
        {
            // This if-else statements are for to display the character based on the chosen character by the user
            // The default value of choseCharacter variable is man character 
            if (ChooseCharacter.chosenCharacter == "woman")
            {
                player.Image = Properties.Resources.p2_up; // set player faces up
            }
            else
            {
                player.Image = Properties.Resources.up; // set player faces up
            }
            
            foreach(PictureBox i in zombiesList)
            {
                this.Controls.Remove(i); // remove all the zombies on the screen
            }
            zombiesList.Clear(); // clear the zombieList

            foreach (PictureBox i in medicList)
            {
                this.Controls.Remove(i); // remove all the medics on the screen
            }
            medicList.Clear(); // clear the medicList

            foreach (PictureBox i in gunList)
            {
                this.Controls.Remove(i); // remove all the guns on the screen
            }
            gunList.Clear();

            foreach (PictureBox i in shieldList)
            {
                this.Controls.Remove(i); // Remove all the shields on the screen
            }
            shieldList.Clear();

            foreach (PictureBox i in grenadeList)
            {
                this.Controls.Remove(i); // remove all the grenade on the screen
            }
            grenadeList.Clear(); // clear the grenadeList

            for (int i = 0; i < 3; i++)
            {
                MakeZombies(); // create 3 zombies on the screen
            }

            goup = false;
            godown = false;
            goleft = false;
            goright = false;
            gameOver = false;
            playerHealth = 100;
            score = 0;
            ammo = 10;
            level = 1;
            tempScore = 0;

            superGun.Image = null;
            laserGun.Image = null;

            Array.Clear(inventory.bag, 0, inventory.bag.Length);
            inventory.numberOfItem = 0;

            GameTimer.Start();
            MedicTimer.Start();
            SuperGunTimer.Start();
            shieldTimer.Start();
            GrenadeTimer.Start();
        }

        public int Get_Ammo()
        {   //used for unit testing
            return ammo;
        }

        public void TestAmmoReduce(int value)
        {
            ammo -= value;
        }

        public int Get_HP()
        {   //used for unit testing
            return playerHealth;
        }

        public void TestHpReduce(int value)
        {
            playerHealth -= value;
        }

        public int Get_ZombieCount()
        {   //used for unit testing
            return zombiesList.Count();
        }

        public void TestZombieIncrease(int value)
        {
            for(int i = 0; i < value; i++)
            {
                MakeZombies();
            }
        }

        public int Get_Level()
        {   //used for unit testing
            return level;
        }

        public void TestLevelIncease()
        {
            if (tempScore == 10)
            {  
                level++;
                tempScore = 0;
                MakeZombies(); 
            }
        }

        public void Set_TempScore(int temp)
        {   //used for unit testing
            tempScore = temp;
        }

        public int Get_TempScore()
        {   //used for unit testing
            return tempScore;
        }

        public int getNumberOfGunCollected()
        {
            //used for unit testing
            return inventory.numberOfGunCollected();
        }

        public string getTypeOfGun()
        {
            //used for unit testing
            return guns.selectGun(3, inventory);
        }

        public void testCollectGun(string item)
        {
            inventory.collectItem(item);
        }


        // This public method will return the ShieldList from the program 
        public List<PictureBox> Get_ListOfShield()
        {
            // Used for unit testing purpose
            return shieldList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This if-else statements are for to display the character based on the chosen character by the user
            // The default value of choseCharacter variable is man character 
            if (ChooseCharacter.chosenCharacter == "woman")
            {
                player.Image = Properties.Resources.p2_up;
            }
            else
            {
                player.Image = Properties.Resources.up;
            }
        }
    }
}
