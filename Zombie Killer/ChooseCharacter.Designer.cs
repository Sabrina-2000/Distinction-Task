namespace Zombie_Killer
{
    partial class ChooseCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCharacter));
            this.label1 = new System.Windows.Forms.Label();
            this.ManChar = new System.Windows.Forms.PictureBox();
            this.WomanChar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WomanChar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a character";
            // 
            // ManChar
            // 
            this.ManChar.BackColor = System.Drawing.SystemColors.Control;
            this.ManChar.Image = ((System.Drawing.Image)(resources.GetObject("ManChar.Image")));
            this.ManChar.Location = new System.Drawing.Point(390, 129);
            this.ManChar.Margin = new System.Windows.Forms.Padding(2);
            this.ManChar.Name = "ManChar";
            this.ManChar.Size = new System.Drawing.Size(71, 107);
            this.ManChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ManChar.TabIndex = 1;
            this.ManChar.TabStop = false;
            this.ManChar.Click += new System.EventHandler(this.ManChar_Click);
            this.ManChar.MouseLeave += new System.EventHandler(this.ManChar_MouseLeave);
            this.ManChar.MouseHover += new System.EventHandler(this.ManChar_MouseHover);
            // 
            // WomanChar
            // 
            this.WomanChar.Image = global::Zombie_Killer.Properties.Resources.p2_down;
            this.WomanChar.Location = new System.Drawing.Point(133, 129);
            this.WomanChar.Margin = new System.Windows.Forms.Padding(2);
            this.WomanChar.Name = "WomanChar";
            this.WomanChar.Size = new System.Drawing.Size(71, 105);
            this.WomanChar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WomanChar.TabIndex = 2;
            this.WomanChar.TabStop = false;
            this.WomanChar.Click += new System.EventHandler(this.WomanChar_Click);
            this.WomanChar.MouseLeave += new System.EventHandler(this.WomanChar_MouseLeave);
            this.WomanChar.MouseHover += new System.EventHandler(this.WomanChar_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Man";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Woman";
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.Control;
            this.Confirm.Location = new System.Drawing.Point(259, 280);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 5;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // ChooseCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 341);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WomanChar);
            this.Controls.Add(this.ManChar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChooseCharacter";
            this.Text = "ChooseCharacter";
            ((System.ComponentModel.ISupportInitialize)(this.ManChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WomanChar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ManChar;
        private System.Windows.Forms.PictureBox WomanChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Confirm;
    }
}