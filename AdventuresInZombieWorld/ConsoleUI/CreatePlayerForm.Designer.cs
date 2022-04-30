
namespace ConsoleUI
{
    partial class CreatePlayerForm
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
            this.name_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.password2_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.password2_textBox = new System.Windows.Forms.TextBox();
            this.pickPlayer_label = new System.Windows.Forms.Label();
            this.prev_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.player_imageBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.playerStat_pictureBox = new System.Windows.Forms.PictureBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showPass_button = new System.Windows.Forms.Button();
            this.hidePass_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player_imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStat_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.Red;
            this.name_label.Location = new System.Drawing.Point(12, 70);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(98, 20);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "User Name";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.Red;
            this.password_label.Location = new System.Drawing.Point(12, 125);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(86, 20);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // password2_label
            // 
            this.password2_label.AutoSize = true;
            this.password2_label.BackColor = System.Drawing.Color.Transparent;
            this.password2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2_label.ForeColor = System.Drawing.Color.Red;
            this.password2_label.Location = new System.Drawing.Point(12, 180);
            this.password2_label.Name = "password2_label";
            this.password2_label.Size = new System.Drawing.Size(162, 20);
            this.password2_label.TabIndex = 4;
            this.password2_label.Text = "Re-enter Password";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(180, 125);
            this.password_textBox.MaxLength = 15;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(174, 20);
            this.password_textBox.TabIndex = 5;
            // 
            // password2_textBox
            // 
            this.password2_textBox.Location = new System.Drawing.Point(180, 180);
            this.password2_textBox.Name = "password2_textBox";
            this.password2_textBox.Size = new System.Drawing.Size(174, 20);
            this.password2_textBox.TabIndex = 6;
            // 
            // pickPlayer_label
            // 
            this.pickPlayer_label.AutoSize = true;
            this.pickPlayer_label.BackColor = System.Drawing.Color.Transparent;
            this.pickPlayer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickPlayer_label.ForeColor = System.Drawing.Color.Red;
            this.pickPlayer_label.Location = new System.Drawing.Point(9, 9);
            this.pickPlayer_label.Name = "pickPlayer_label";
            this.pickPlayer_label.Size = new System.Drawing.Size(252, 37);
            this.pickPlayer_label.TabIndex = 8;
            this.pickPlayer_label.Text = "Create Account";
            // 
            // prev_button
            // 
            this.prev_button.BackColor = System.Drawing.Color.Brown;
            this.prev_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prev_button.Location = new System.Drawing.Point(371, 372);
            this.prev_button.Name = "prev_button";
            this.prev_button.Size = new System.Drawing.Size(78, 29);
            this.prev_button.TabIndex = 9;
            this.prev_button.Text = "Prev";
            this.prev_button.UseVisualStyleBackColor = false;
            this.prev_button.Click += new System.EventHandler(this.prev_button_Click);
            // 
            // next_button
            // 
            this.next_button.BackColor = System.Drawing.Color.Brown;
            this.next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.next_button.Location = new System.Drawing.Point(540, 372);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(78, 29);
            this.next_button.TabIndex = 10;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = false;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // player_imageBox
            // 
            this.player_imageBox.BackColor = System.Drawing.Color.Transparent;
            this.player_imageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player_imageBox.Image = global::ConsoleUI.Properties.Resources.SoldierImage5a;
            this.player_imageBox.Location = new System.Drawing.Point(371, 44);
            this.player_imageBox.Name = "player_imageBox";
            this.player_imageBox.Size = new System.Drawing.Size(247, 322);
            this.player_imageBox.TabIndex = 0;
            this.player_imageBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ConsoleUI.Properties.Resources.BioHazard1__3_;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 204);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(180, 70);
            this.name_textBox.Multiline = true;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(174, 20);
            this.name_textBox.TabIndex = 2;
            // 
            // playerStat_pictureBox
            // 
            this.playerStat_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.playerStat_pictureBox.Image = global::ConsoleUI.Properties.Resources.SSGCraneStatsImage;
            this.playerStat_pictureBox.Location = new System.Drawing.Point(638, 44);
            this.playerStat_pictureBox.Name = "playerStat_pictureBox";
            this.playerStat_pictureBox.Size = new System.Drawing.Size(286, 372);
            this.playerStat_pictureBox.TabIndex = 12;
            this.playerStat_pictureBox.TabStop = false;
            // 
            // submit_button
            // 
            this.submit_button.BackColor = System.Drawing.Color.Brown;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submit_button.Location = new System.Drawing.Point(846, 482);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(78, 29);
            this.submit_button.TabIndex = 14;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(219, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Max Characters(15)";
            // 
            // showPass_button
            // 
            this.showPass_button.Location = new System.Drawing.Point(303, 206);
            this.showPass_button.Name = "showPass_button";
            this.showPass_button.Size = new System.Drawing.Size(51, 23);
            this.showPass_button.TabIndex = 16;
            this.showPass_button.Text = "Show";
            this.showPass_button.UseVisualStyleBackColor = true;
            // 
            // hidePass_button
            // 
            this.hidePass_button.Location = new System.Drawing.Point(303, 206);
            this.hidePass_button.Name = "hidePass_button";
            this.hidePass_button.Size = new System.Drawing.Size(51, 23);
            this.hidePass_button.TabIndex = 17;
            this.hidePass_button.Text = "Hide";
            this.hidePass_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(876, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreatePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.BackgroundImage = global::ConsoleUI.Properties.Resources.ZombieImageBG4;
            this.ClientSize = new System.Drawing.Size(936, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showPass_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.playerStat_pictureBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.prev_button);
            this.Controls.Add(this.pickPlayer_label);
            this.Controls.Add(this.password2_textBox);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.password2_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.player_imageBox);
            this.Controls.Add(this.hidePass_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreatePlayerForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player_imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerStat_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player_imageBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label password2_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox password2_textBox;
        private System.Windows.Forms.Label pickPlayer_label;
        private System.Windows.Forms.Button prev_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.PictureBox playerStat_pictureBox;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showPass_button;
        private System.Windows.Forms.Button hidePass_button;
        private System.Windows.Forms.Button button1;
    }
}