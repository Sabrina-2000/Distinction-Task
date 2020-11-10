using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Killer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); //Create the form1
            this.Hide(); //Hide this form 
            form1.ShowDialog(); //Show the form1
            this.Close(); //Close this form
        }

        private void Scoreboard_Click(object sender, EventArgs e)
        {
            Scoreboard board = new Scoreboard(); //Create the scoreboard form
            board.Show(); //Show the scoreboard
        }

        // If the user click the Character option in the menu then it will show the Character form
        private void Character_Click(object sender, EventArgs e)
        {
            ChooseCharacter character = new ChooseCharacter(); //Create the character form
            character.Show(); //Show the character
        }

    }
}
