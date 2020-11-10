namespace Zombie_Killer
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Scoreboard = new System.Windows.Forms.Label();
            this.Character = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Scoreboard
            // 
            this.Scoreboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scoreboard.AutoSize = true;
            this.Scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoreboard.ForeColor = System.Drawing.Color.White;
            this.Scoreboard.Location = new System.Drawing.Point(344, 543);
            this.Scoreboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Scoreboard.Name = "Scoreboard";
            this.Scoreboard.Size = new System.Drawing.Size(164, 31);
            this.Scoreboard.TabIndex = 7;
            this.Scoreboard.Text = "Scoreboard";
            this.Scoreboard.Click += new System.EventHandler(this.Scoreboard_Click);
            // 
            // Character
            // 
            this.Character.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Character.AutoSize = true;
            this.Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Character.ForeColor = System.Drawing.Color.White;
            this.Character.Location = new System.Drawing.Point(356, 469);
            this.Character.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(143, 31);
            this.Character.TabIndex = 6;
            this.Character.Text = "Character";
            this.Character.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Character.Click += new System.EventHandler(this.Character_Click);
            // 
            // Play
            // 
            this.Play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Play.AutoSize = true;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.White;
            this.Play.Location = new System.Drawing.Point(392, 391);
            this.Play.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(71, 31);
            this.Play.TabIndex = 5;
            this.Play.Text = "Play";
            this.Play.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(136, 113);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(615, 108);
            this.Title.TabIndex = 4;
            this.Title.Text = "Zombie Killer";
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 701);
            this.Controls.Add(this.Scoreboard);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Scoreboard;
        private System.Windows.Forms.Label Character;
        private System.Windows.Forms.Label Play;
        private System.Windows.Forms.Label Title;
    }
}