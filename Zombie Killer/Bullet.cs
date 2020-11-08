using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Windows.Forms;

namespace Zombie_Killer
{
    class bullet
    {

        // start the variable

        public string direction; // creating a public string called direction
        public int speed = 10; // creating a integer called speed and assigning a value of 20
        string typeOfGun;
        PictureBox Bullet = new PictureBox(); // create a picture box 
        private Timer bulletTimer = new Timer(); // create a new timer called tm. 

        public int bulletLeft; // create a new public integer
        public int bulletTop; // create a new public integer

        // end of the variables

        public void MakeBullet(Form form,string typeOfGunFromGame)
        {
            typeOfGun = typeOfGunFromGame;
            // this function will add the bullet to the game play
            // it is required to be called from the main class
            //Bullet.BackColor = System.Drawing.Color.White; // set the colour white for the bullet
            //Bullet.Image = Properties.Resources.SuperGunBullet;
            //Bullet.Size = new Size(5, 5); // set the size to the bullet to 5 pixel by 5 pixel
            Bullet.Tag = "bullet"; // set the tag to bullet
            Bullet.Left = bulletLeft; // set bullet left 
            Bullet.Top = bulletTop; // set bullet right
            Bullet.BringToFront(); // bring the bullet to front of other objects
            form.Controls.Add(Bullet); // add the bullet to the screen
            bulletTimer.Interval = speed; // set the timer interval to speed
            bulletTimer.Tick += new EventHandler(BulletTimerEvent); // assignment the timer with an event
            bulletTimer.Start(); // start the timer

        }

        public void BulletTimerEvent(object sender, EventArgs e)
        {

            if (typeOfGun == "LaserGun")
            {
                speed = 25;
            }
            else if (typeOfGun == "SuperGun")
            {
                speed = 5;
            }
            // if direction equals to left
            if (direction == "left")
            {
                if(typeOfGun == "SuperGun"){
                    Bullet.Image = Properties.Resources.SuperGunBulletHorizontal;
                }
                else if (typeOfGun == "LaserGun")
                {
                    Bullet.Image = Properties.Resources.LaserBulletHorizontal;
                }
                else 
                {
                    Bullet.Image = Properties.Resources.NormalBulletHorizontal;
                }
                Bullet.Left -= speed; // move bullet towards the left of the screen
            }
            // if direction equals right
            if (direction == "right")
            {
                if (typeOfGun == "SuperGun")
                {
                    Bullet.Image = Properties.Resources.SuperGunBulletHorizontal;
                }
                else if (typeOfGun == "LaserGun")
                {
                    Bullet.Image = Properties.Resources.LaserBulletHorizontal;
                }
                else
                {
                    Bullet.Image = Properties.Resources.NormalBulletHorizontal;
                }
                Bullet.Left += speed; // move bullet towards the right of the screen
            }
            // if direction is up
            if (direction == "up")
            {
                if (typeOfGun == "SuperGun")
                {
                    Bullet.Image = Properties.Resources.SuperGunBullet;
                }
                else if (typeOfGun == "LaserGun")
                {
                    Bullet.Image = Properties.Resources.LaserBulletHorizontal;
                }
                else
                {
                    Bullet.Image = Properties.Resources.NormalBullet;
                }
                Bullet.Top -= speed; // move the bullet towards top of the screen
            }
            // if direction is down
            if (direction == "down")
            {
                if (typeOfGun == "SuperGun")
                {
                    Bullet.Image = Properties.Resources.SuperGunBullet;
                }
                else if (typeOfGun == "LaserGun")
                {
                    Bullet.Image = Properties.Resources.LaserBulletHorizontal;
                }
                else
                {
                    Bullet.Image = Properties.Resources.NormalBullet;
                }
                Bullet.Top += speed; // move the bullet bottom of the screen
            }

            // if the bullet is less the 16 pixel to the left OR
            // if the bullet is more than 860 pixels to the right OR
            // if the bullet is 10 pixels from the top OR
            // if the bullet is 616 pixels to the bottom OR
            // IF ANY ONE OF THE CONDITIONS ARE MET THEN THE FOLLOWING CODE WILL BE EXECUTED

            if (Bullet.Left < 16 || Bullet.Left > 860 || Bullet.Top < 10 || Bullet.Top > 616)
            {
                bulletTimer.Stop(); // stop the timer
                bulletTimer.Dispose(); // dispose the timer event and component from the program
                Bullet.Dispose(); // dispose the bullet
                bulletTimer = null; // nullify the timer object
                Bullet = null; // nullify the bullet object
            }
        }
    }
}