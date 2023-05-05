
namespace WinFormUI
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.create_accountButton = new System.Windows.Forms.Button();
            this.ForgotPass_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(137, 132);
            this.username_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(217, 30);
            this.username_textBox.TabIndex = 4;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(138, 182);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(216, 30);
            this.password_textBox.TabIndex = 5;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 45);
            this.label5.TabIndex = 6;
            this.label5.Text = "Login";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 63);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::WinFormUI.Properties.Resources.Untitled_design_13_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // create_accountButton
            // 
            this.create_accountButton.BackColor = System.Drawing.Color.Transparent;
            this.create_accountButton.FlatAppearance.BorderSize = 0;
            this.create_accountButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.create_accountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.create_accountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.create_accountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_accountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_accountButton.ForeColor = System.Drawing.Color.Azure;
            this.create_accountButton.Location = new System.Drawing.Point(150, 215);
            this.create_accountButton.Name = "create_accountButton";
            this.create_accountButton.Size = new System.Drawing.Size(139, 37);
            this.create_accountButton.TabIndex = 9;
            this.create_accountButton.Text = "Create Account";
            this.create_accountButton.UseVisualStyleBackColor = false;
            this.create_accountButton.Click += new System.EventHandler(this.CreateAccount_Click);
            this.create_accountButton.MouseLeave += new System.EventHandler(this.createAccount_MouseLeave);
            this.create_accountButton.MouseHover += new System.EventHandler(this.createAccount_MouseHover);
            // 
            // ForgotPass_button
            // 
            this.ForgotPass_button.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPass_button.FlatAppearance.BorderSize = 0;
            this.ForgotPass_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ForgotPass_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ForgotPass_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ForgotPass_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgotPass_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPass_button.ForeColor = System.Drawing.Color.Azure;
            this.ForgotPass_button.Location = new System.Drawing.Point(118, 241);
            this.ForgotPass_button.Name = "ForgotPass_button";
            this.ForgotPass_button.Size = new System.Drawing.Size(223, 37);
            this.ForgotPass_button.TabIndex = 10;
            this.ForgotPass_button.Text = "Forgot Username/Password";
            this.ForgotPass_button.UseVisualStyleBackColor = false;
            this.ForgotPass_button.MouseLeave += new System.EventHandler(this.ForgotPass_button_MouseLeave);
            this.ForgotPass_button.MouseHover += new System.EventHandler(this.ForgotPass_button_MouseHover);
            // 
            // login_button
            // 
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.login_button.Location = new System.Drawing.Point(266, 305);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(87, 37);
            this.login_button.TabIndex = 11;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(307, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.showPass_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.Untitled_design_15_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(424, 471);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.ForgotPass_button);
            this.Controls.Add(this.create_accountButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button create_accountButton;
        private System.Windows.Forms.Button ForgotPass_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button button4;
    }
}