using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zombie_Killer
{
    public partial class Form1 : Form
    {

        // start the variables

        bool goup; // this boolean will be used for the player to go up the screen
        bool godown; // this boolean will be used for the player to go down the screen
        bool goleft; // this boolean will be used for the player to go left to the screen
        bool goright; // this boolean will be used for the player to right to the screen
        string facing = "up"; // this string is called facing and it will be used to guide the bullets
        int playerHealth = 100; // this double vaiable is called player health
        int speed = 10; // this interget is for the speed of the player
        int ammo = 10; // this integer will hold the number of ammo the player has start of the game
        int zombieSpeed = 3; // this integer will hold the speed which the zombies move in the game
        int score = 0; // this integer will hold the score the player achieved through the game
        bool gameOver = false; // this boolean is false in the beginning and it will be used when the game is finished
        string typeOfGun = "";
        Random rnd = new Random(); // this is an instance of the random class we will use this to create a random number for this game

        List<PictureBox> zombiesList = new List<PictureBox>(); // list to store the zombie
        List<PictureBox> medicList = new List<PictureBox>(); // list to store the medic
        List<PictureBox> gunList = new List<PictureBox>(); // list to store the medic

        Inventory inventory = new Inventory();
        Gun guns = new Gun();

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
        {   // drop the medic after every 20 seconds
            DropSuperGun();
            SuperGunTimer.Enabled = false;
        }

        private void LaserGunTimerEvent(object sender, EventArgs e)
        {   // drop the medic after 30 seconds
            DropLaserGun();
            LaserGunTimer.Enabled = false;
        }


        private void MainTimerEvent(object sender, EventArgs e)
        {
            if(playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                GameTimer.Stop();
                MedicTimer.Stop();
                SuperGunTimer.Stop();
                LaserGunTimer.Stop();
            }

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;

            if(goleft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if(goright == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if(goup == true && player.Top > 45)
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
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player intersects with ammor 
                    {
                        this.Controls.Remove(x); // remove the ammo on screen
                        ((PictureBox)x).Dispose(); // dispose the picture box
                        ammo += 5; // add the ammo to 5
                    }
                }

                if (x is PictureBox && (string)x.Tag == "medic")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player intersects with medic 
                    {
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
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player intersects with ammor 
                    {
                        this.Controls.Remove(x); // remove the ammo on screen
                        ((PictureBox)x).Dispose(); // dispose the picture box
                        inventory.collectItem("SuperGun");// get super gun
                        superGun.Image = Properties.Resources.SuperGun;
                        LaserGunTimer.Enabled = true;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "laserGun")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player intersects with ammor 
                    {
                        this.Controls.Remove(x); // remove the ammo on screen
                        ((PictureBox)x).Dispose(); // dispose the picture box
                        inventory.collectItem("LaserGun");// get super gun
                        laserGun.Image = Properties.Resources.LaserGun;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) // if the player's intersects with zombie
                    {
                        playerHealth -= 1; //player's health minus by 1
                    }
                    // let the zombie chase the player
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

                            this.Controls.Remove(j); // remove the bullets on screen
                            ((PictureBox)j).Dispose(); // dispose the picture box
                            this.Controls.Remove(x); // remove the zombie on screen
                            ((PictureBox)x).Dispose(); // dispose the picture box
                            zombiesList.Remove(((PictureBox)x)); // remove the zombie from the list
                            MakeZombies(); // create the zombies
                        }
                    }
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
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

            if((e.KeyCode == Keys.D1) && (inventory.numberOfGun()>=1))
            {
                typeOfGun = guns.selectGun(1, inventory);
            }

            if ((e.KeyCode == Keys.D2) && (inventory.numberOfGun() >= 2))
            {
                typeOfGun = guns.selectGun(2, inventory);
            }

            if ((e.KeyCode == Keys.D3) && (inventory.numberOfGun() >= 2))
            {
                typeOfGun = guns.selectGun(3, inventory);
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
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
                player.Image = Properties.Resources.left; // player faces left
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                facing = "right";
                player.Image = Properties.Resources.right; // player faces right
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                facing = "up";
                player.Image = Properties.Resources.up; // player faces up
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                facing = "down";
                player.Image = Properties.Resources.down; // player faces down
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

        private void DropSuperGun()
        {
            PictureBox superGun = new PictureBox();
           
            superGun.Image = Properties.Resources.SuperGun;
            superGun.SizeMode = PictureBoxSizeMode.AutoSize;
            superGun.Left = rnd.Next(15, this.ClientSize.Width - superGun.Width);
            superGun.Top = rnd.Next(60, this.ClientSize.Height - superGun.Height);
            superGun.Tag = "superGun";
            this.Controls.Add(superGun); // add the medic to the screen
            superGun.BringToFront(); // bring the medic to the front
            player.BringToFront(); // bring the player to the front
        }

        private void DropLaserGun()
        {
            PictureBox laserGun = new PictureBox();
            laserGun.Image = Properties.Resources.LaserGun;
            laserGun.SizeMode = PictureBoxSizeMode.AutoSize;
            laserGun.Left = rnd.Next(15, this.ClientSize.Width - laserGun.Width);
            laserGun.Top = rnd.Next(60, this.ClientSize.Height - laserGun.Height);
            laserGun.Tag = "laserGun";
            this.Controls.Add(laserGun); // add the medic to the screen
            laserGun.BringToFront(); // bring the medic to the front
            player.BringToFront(); // bring the player to the front
        }

        private void RestartGame()
        {
            player.Image = Properties.Resources.up; // set player faces up

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

            superGun.Image = null;
            laserGun.Image = null;

            GameTimer.Start();
            MedicTimer.Start();
            SuperGunTimer.Start();
        }

    }
}
