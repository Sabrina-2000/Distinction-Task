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
            this.Scoreboard.AutoSize = true;
            this.Scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoreboard.ForeColor = System.Drawing.Color.White;
            this.Scoreboard.Location = new System.Drawing.Point(416, 506);
            this.Scoreboard.Name = "Scoreboard";
            this.Scoreboard.Size = new System.Drawing.Size(133, 25);
            this.Scoreboard.TabIndex = 7;
            this.Scoreboard.Text = "Scoreboard";
            this.Scoreboard.Click += new System.EventHandler(this.Scoreboard_Click);
            // 
            // Character
            // 
            this.Character.AutoSize = true;
            this.Character.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Character.ForeColor = System.Drawing.Color.White;
            this.Character.Location = new System.Drawing.Point(425, 467);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(115, 25);
            this.Character.TabIndex = 6;
            this.Character.Text = "Character";
            // 
            // Play
            // 
            this.Play.AutoSize = true;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.White;
            this.Play.Location = new System.Drawing.Point(451, 424);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(58, 25);
            this.Play.TabIndex = 5;
            this.Play.Text = "Play";
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(155, 129);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(615, 108);
            this.Title.TabIndex = 4;
            this.Title.Text = "Zombie Killer";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.Scoreboard);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Title);
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