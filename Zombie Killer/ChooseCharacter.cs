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
    /// <summary>
    /// This is a form for the Character option in the menu
    /// The user should be able to choose one character out 2 options to play the game
    /// </summary>
    public partial class ChooseCharacter : Form
    {
        // The default value of this variable is 'Man' character
        public static string chosenCharacter = "man";
        public ChooseCharacter()
        {
            InitializeComponent();
        }

        // If the user clicked on the man character then this function will give it darkblue background
        // To indicate the status that this character is chosen
        private void ManChar_Click(object sender, EventArgs e)
        {
            if (WomanChar.BackColor == Control.DefaultBackColor)
            {
                ManChar.BackColor = Color.DarkBlue;
            }
            else if (WomanChar.BackColor == Color.DarkBlue)
            {
                WomanChar.BackColor = Control.DefaultBackColor;
                ManChar.BackColor = Color.DarkBlue;
            }
            
            chosenCharacter = "man";
        }

        // If the user clicked on the woman character then this function will give it darkblue background
        // To indicate the status that this character is chosen
        private void WomanChar_Click(object sender, EventArgs e)
        {
            if (ManChar.BackColor == Control.DefaultBackColor)
            {
                WomanChar.BackColor = Color.DarkBlue;
            }
            else if (ManChar.BackColor == Color.DarkBlue)
            {
                ManChar.BackColor = Control.DefaultBackColor;
                WomanChar.BackColor = Color.DarkBlue;
            }
            chosenCharacter = "woman";
        }

        // Hover function for man character 
        private void ManChar_MouseHover(object sender, EventArgs e)
        {
            ManChar.BorderStyle = BorderStyle.FixedSingle;
        }

        // This function applies when the mouse leave the man character
        private void ManChar_MouseLeave(object sender, EventArgs e)
        {
            ManChar.BorderStyle = BorderStyle.None;
        }

        // Hover function for woman character 
        private void WomanChar_MouseHover(object sender, EventArgs e)
        {
            WomanChar.BorderStyle = BorderStyle.FixedSingle;
        }

        // This function applies when the mouse leave the woman character
        private void WomanChar_MouseLeave(object sender, EventArgs e)
        {
            WomanChar.BorderStyle = BorderStyle.None;
        }

        // If the user click the confirm button then it will close the form and use the chosen character value
        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
