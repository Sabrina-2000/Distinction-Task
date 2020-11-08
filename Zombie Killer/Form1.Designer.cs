namespace Zombie_Killer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtAmmo = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.MedicTimer = new System.Windows.Forms.Timer(this.components);
            this.txtInventory = new System.Windows.Forms.Label();
            this.SuperGunTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.superGun = new System.Windows.Forms.PictureBox();
            this.laserGun = new System.Windows.Forms.PictureBox();
            this.LaserGunTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserGun)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(13, 13);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(93, 24);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(162, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(71, 24);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Kills: 0";
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.ForeColor = System.Drawing.Color.White;
            this.Health.Location = new System.Drawing.Point(655, 13);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(76, 24);
            this.Health.TabIndex = 2;
            this.Health.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(729, 13);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(183, 23);
            this.healthBar.TabIndex = 3;
            this.healthBar.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // MedicTimer
            // 
            this.MedicTimer.Enabled = true;
            this.MedicTimer.Interval = 10000;
            this.MedicTimer.Tick += new System.EventHandler(this.MedicTimerEvent);
            // 
            // txtInventory
            // 
            this.txtInventory.AutoSize = true;
            this.txtInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.ForeColor = System.Drawing.Color.White;
            this.txtInventory.Location = new System.Drawing.Point(321, 13);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(101, 24);
            this.txtInventory.TabIndex = 6;
            this.txtInventory.Text = "Inventory:";
            // 
            // SuperGunTimer
            // 
            this.SuperGunTimer.Enabled = true;
            this.SuperGunTimer.Interval = 5000;
            this.SuperGunTimer.Tick += new System.EventHandler(this.SuperGunTimerEvent);
            // 
            // player
            // 
            this.player.Image = global::Zombie_Killer.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(435, 549);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // superGun
            // 
            this.superGun.Location = new System.Drawing.Point(419, 1);
            this.superGun.Name = "superGun";
            this.superGun.Size = new System.Drawing.Size(87, 51);
            this.superGun.TabIndex = 8;
            this.superGun.TabStop = false;
            // 
            // laserGun
            // 
            this.laserGun.Location = new System.Drawing.Point(503, 1);
            this.laserGun.Name = "laserGun";
            this.laserGun.Size = new System.Drawing.Size(90, 51);
            this.laserGun.TabIndex = 7;
            this.laserGun.TabStop = false;
            // 
            // LaserGunTimer
            // 
            this.LaserGunTimer.Interval = 5000;
            this.LaserGunTimer.Tick += new System.EventHandler(this.LaserGunTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.superGun);
            this.Controls.Add(this.laserGun);
            this.Name = "Form1";
            this.Text = "Zombie Killer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserGun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAmmo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer MedicTimer;
        private System.Windows.Forms.Label txtInventory;
        private System.Windows.Forms.PictureBox laserGun;
        private System.Windows.Forms.Timer SuperGunTimer;
        private System.Windows.Forms.PictureBox superGun;
        private System.Windows.Forms.Timer LaserGunTimer;
    }
}

