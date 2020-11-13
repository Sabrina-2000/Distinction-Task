using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Killer
{
    public partial class Scoreboard : Form
    {
        string path = "../../Text/Scoreboard.txt"; //The path of the scoreboard.txt
        string path2 = "../../Text/date.txt"; //The path of the date.txt
        public Scoreboard()
        {
            InitializeComponent();
            DisplayScore(); 
        }

        private void DisplayScore()
        {
            using (StreamReader file = new StreamReader(path)) 
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    kills.Text += ln + "\n"; //Write the text to the form
                }
                file.Close(); //Close the file
            }

            using (StreamReader file = new StreamReader(path2))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    date.Text += ln + "\n"; //Write the text to the form
                }
                file.Close(); //Close the file
            }
        }
    }
}
