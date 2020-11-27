using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Killer
{
    class Explosion
    {
        // start the variable

        public string direction; // creating a public string called direction
        PictureBox explosion = new PictureBox(); // create a picture box 
        private Timer explosionTimer = new Timer(); // create a new timer called explosionTimer. 
        public int explosionLeft; // create a new public integer
        public int explosionTop; // create a new public integer

        // end of the variables

        public void MakeExplosion(Form form)
        {
            explosion.Tag = "explosion"; // set the tag to explosion
            explosion.Left = explosionLeft; // set explosion left 
            explosion.Top = explosionTop; // set explosion right
            explosion.BringToFront(); // bring the explosion to front of other objects
            form.Controls.Add(explosion); // add the explosion to the screen
            explosionTimer.Tick += new EventHandler(ExplosionTimerEvent); // assignment the timer with an event
            explosionTimer.Start(); // start the timer
        }

        private void ExplosionTimerEvent(object sender, EventArgs e)
        {
            explosion.Image = Properties.Resources.explosion;
            explosion.SizeMode = PictureBoxSizeMode.AutoSize;

            // if the explosion is less the 16 pixel to the left OR
            // if the explosion is more than 860 pixels to the right OR
            // if the explosion is 10 pixels from the top OR
            // if the explosion is 616 pixels to the bottom OR
            // IF ANY ONE OF THE CONDITIONS ARE MET THEN THE FOLLOWING CODE WILL BE EXECUTED

            if (explosion.Left < 16 || explosion.Left > 860 || explosion.Top < 10 || explosion.Top > 616)
            {
                explosionTimer.Stop(); // stop the timer
                explosionTimer.Dispose(); // dispose the timer event and component from the program
                explosion.Dispose(); // dispose the explosion
                explosionTimer = null; // nullify the timer object
                explosion = null; // nullify the explosion object
            }
        }
    }
}
