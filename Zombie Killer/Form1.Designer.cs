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
            this.LaserGunTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.superGun = new System.Windows.Forms.PictureBox();
            this.laserGun = new System.Windows.Forms.PictureBox();
            this.shieldTimer = new System.Windows.Forms.Timer(this.components);
            this.shield = new System.Windows.Forms.Label();
            this.shieldBar = new System.Windows.Forms.ProgressBar();
            this.GrenadeTimer = new System.Windows.Forms.Timer(this.components);
            this.grenade = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grenade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmmo
            // 
            this.txtAmmo.AutoSize = true;
            this.txtAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmo.ForeColor = System.Drawing.Color.White;
            this.txtAmmo.Location = new System.Drawing.Point(17, 16);
            this.txtAmmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAmmo.Name = "txtAmmo";
            this.txtAmmo.Size = new System.Drawing.Size(114, 29);
            this.txtAmmo.TabIndex = 0;
            this.txtAmmo.Text = "Ammo: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(216, 15);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(92, 29);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Kills: 0";
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.ForeColor = System.Drawing.Color.White;
            this.Health.Location = new System.Drawing.Point(873, 16);
            this.Health.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(95, 29);
            this.Health.TabIndex = 2;
            this.Health.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(972, 16);
            this.healthBar.Margin = new System.Windows.Forms.Padding(4);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(244, 28);
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
            this.txtInventory.Location = new System.Drawing.Point(428, 16);
            this.txtInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(125, 29);
            this.txtInventory.TabIndex = 6;
            this.txtInventory.Text = "Inventory:";
            // 
            // SuperGunTimer
            // 
            this.SuperGunTimer.Enabled = true;
            this.SuperGunTimer.Interval = 5000;
            this.SuperGunTimer.Tick += new System.EventHandler(this.SuperGunTimerEvent);
            // 
            // LaserGunTimer
            // 
            this.LaserGunTimer.Interval = 5000;
            this.LaserGunTimer.Tick += new System.EventHandler(this.LaserGunTimerEvent);
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(559, 676);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // superGun
            // 
            this.superGun.Location = new System.Drawing.Point(559, 1);
            this.superGun.Margin = new System.Windows.Forms.Padding(4);
            this.superGun.Name = "superGun";
            this.superGun.Size = new System.Drawing.Size(116, 63);
            this.superGun.TabIndex = 8;
            this.superGun.TabStop = false;
            // 
            // laserGun
            // 
            this.laserGun.Location = new System.Drawing.Point(671, 1);
            this.laserGun.Margin = new System.Windows.Forms.Padding(4);
            this.laserGun.Name = "laserGun";
            this.laserGun.Size = new System.Drawing.Size(120, 63);
            this.laserGun.TabIndex = 7;
            this.laserGun.TabStop = false;
            // 
            // shieldTimer
            // 
            this.shieldTimer.Enabled = true;
            this.shieldTimer.Interval = 35000;
            this.shieldTimer.Tick += new System.EventHandler(this.ShieldTimerEvent);
            // 
            // shield
            // 
            this.shield.AutoSize = true;
            this.shield.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shield.ForeColor = System.Drawing.Color.White;
            this.shield.Location = new System.Drawing.Point(873, 52);
            this.shield.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shield.Name = "shield";
            this.shield.Size = new System.Drawing.Size(95, 29);
            this.shield.TabIndex = 9;
            this.shield.Text = "Shield:";
            // 
            // shieldBar
            // 
            this.shieldBar.Location = new System.Drawing.Point(972, 52);
            this.shieldBar.Margin = new System.Windows.Forms.Padding(4);
            this.shieldBar.Name = "shieldBar";
            this.shieldBar.Size = new System.Drawing.Size(244, 28);
            this.shieldBar.TabIndex = 10;
            // 
            // GrenadeTimer
            // 
            this.GrenadeTimer.Enabled = true;
            this.GrenadeTimer.Interval = 9000;
            this.GrenadeTimer.Tick += new System.EventHandler(this.GrenadeTimerEvent);
            // 
            // grenade
            // 
            this.grenade.Location = new System.Drawing.Point(789, -1);
            this.grenade.Name = "grenade";
            this.grenade.Size = new System.Drawing.Size(77, 65);
            this.grenade.TabIndex = 11;
            this.grenade.TabStop = false;
            this.grenade.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1232, 814);
            this.Controls.Add(this.grenade);
            this.Controls.Add(this.shieldBar);
            this.Controls.Add(this.shield);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtAmmo);
            this.Controls.Add(this.superGun);
            this.Controls.Add(this.laserGun);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Zombie Killer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grenade)).EndInit();
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
        private System.Windows.Forms.Timer shieldTimer;
        private System.Windows.Forms.Label shield;
        private System.Windows.Forms.ProgressBar shieldBar;
        private System.Windows.Forms.Timer GrenadeTimer;
        private System.Windows.Forms.PictureBox grenade;
    }
}

