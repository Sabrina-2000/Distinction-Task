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
        int testing;
        Random rnd = new Random(); // this is an instance of the random class we will use this to create a random number for this game

        List<PictureBox> zombiesList = new List<PictureBox>();


        public Form1()
        {
            InitializeComponent();
            RestartGame();
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
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

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
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesList.Remove(((PictureBox)x));
                            MakeZombies();
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

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

           if (e.KeyCode == Keys.Enter && gameOver == true)
           {
                RestartGame();
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
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }
        }

        private void ShootBullet(string direction)
        {
            bullet shootBullet = new bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = rnd.Next(0, 900);
            zombie.Top = rnd.Next(0, 800);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = rnd.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        }

        private void RestartGame()
        {
            player.Image = Properties.Resources.up;

            foreach(PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }
            zombiesList.Clear();

            for(int i = 0; i < 3; i++)
            {
                MakeZombies();
            }

            goup = false;
            godown = false;
            goleft = false;
            goright = false;
            gameOver = false;
            playerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();
        }
    }
}
