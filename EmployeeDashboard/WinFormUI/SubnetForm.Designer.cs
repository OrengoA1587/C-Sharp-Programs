
namespace WinFormUI
{
    partial class SubnetForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.broadcastAddress_textBox = new System.Windows.Forms.TextBox();
            this.lastUseable_textBox = new System.Windows.Forms.TextBox();
            this.firstUseable_textBox = new System.Windows.Forms.TextBox();
            this.cidrNotat = new System.Windows.Forms.TextBox();
            this.networkAddress_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oct_four = new System.Windows.Forms.TextBox();
            this.oct_three = new System.Windows.Forms.TextBox();
            this.oct_two = new System.Windows.Forms.TextBox();
            this.oct_one = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.networkAddress_textBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.submit_button);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.broadcastAddress_textBox);
            this.panel1.Controls.Add(this.lastUseable_textBox);
            this.panel1.Controls.Add(this.firstUseable_textBox);
            this.panel1.Controls.Add(this.cidrNotat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.oct_four);
            this.panel1.Controls.Add(this.oct_three);
            this.panel1.Controls.Add(this.oct_two);
            this.panel1.Controls.Add(this.oct_one);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 355);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormUI.Properties.Resources.CiscoLogo;
            this.pictureBox1.Location = new System.Drawing.Point(18, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(599, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "CIDR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "IP Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Broadcast Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Last Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "First Address";
            // 
            // submit_button
            // 
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(577, 307);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 30);
            this.submit_button.TabIndex = 35;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Network Address";
            // 
            // broadcastAddress_textBox
            // 
            this.broadcastAddress_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broadcastAddress_textBox.Location = new System.Drawing.Point(171, 237);
            this.broadcastAddress_textBox.Multiline = true;
            this.broadcastAddress_textBox.Name = "broadcastAddress_textBox";
            this.broadcastAddress_textBox.Size = new System.Drawing.Size(402, 28);
            this.broadcastAddress_textBox.TabIndex = 33;
            // 
            // lastUseable_textBox
            // 
            this.lastUseable_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUseable_textBox.Location = new System.Drawing.Point(171, 186);
            this.lastUseable_textBox.Multiline = true;
            this.lastUseable_textBox.Name = "lastUseable_textBox";
            this.lastUseable_textBox.Size = new System.Drawing.Size(402, 28);
            this.lastUseable_textBox.TabIndex = 32;
            // 
            // firstUseable_textBox
            // 
            this.firstUseable_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstUseable_textBox.Location = new System.Drawing.Point(171, 133);
            this.firstUseable_textBox.Multiline = true;
            this.firstUseable_textBox.Name = "firstUseable_textBox";
            this.firstUseable_textBox.Size = new System.Drawing.Size(402, 28);
            this.firstUseable_textBox.TabIndex = 31;
            // 
            // cidrNotat
            // 
            this.cidrNotat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidrNotat.Location = new System.Drawing.Point(541, 24);
            this.cidrNotat.MaxLength = 2;
            this.cidrNotat.Name = "cidrNotat";
            this.cidrNotat.Size = new System.Drawing.Size(52, 26);
            this.cidrNotat.TabIndex = 30;
            this.cidrNotat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // networkAddress_textBox
            // 
            this.networkAddress_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.networkAddress_textBox.Location = new System.Drawing.Point(171, 83);
            this.networkAddress_textBox.Multiline = true;
            this.networkAddress_textBox.Name = "networkAddress_textBox";
            this.networkAddress_textBox.Size = new System.Drawing.Size(402, 34);
            this.networkAddress_textBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = ".";
            // 
            // oct_four
            // 
            this.oct_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oct_four.Location = new System.Drawing.Point(432, 24);
            this.oct_four.MaxLength = 3;
            this.oct_four.Name = "oct_four";
            this.oct_four.Size = new System.Drawing.Size(78, 26);
            this.oct_four.TabIndex = 25;
            this.oct_four.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oct_three
            // 
            this.oct_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oct_three.Location = new System.Drawing.Point(324, 24);
            this.oct_three.MaxLength = 3;
            this.oct_three.Name = "oct_three";
            this.oct_three.Size = new System.Drawing.Size(78, 26);
            this.oct_three.TabIndex = 24;
            this.oct_three.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oct_two
            // 
            this.oct_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oct_two.Location = new System.Drawing.Point(216, 23);
            this.oct_two.MaxLength = 3;
            this.oct_two.Name = "oct_two";
            this.oct_two.Size = new System.Drawing.Size(78, 26);
            this.oct_two.TabIndex = 23;
            this.oct_two.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oct_one
            // 
            this.oct_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oct_one.Location = new System.Drawing.Point(108, 23);
            this.oct_one.MaxLength = 3;
            this.oct_one.Name = "oct_one";
            this.oct_one.Size = new System.Drawing.Size(78, 26);
            this.oct_one.TabIndex = 22;
            this.oct_one.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MingLiU-ExtB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(338, 35);
            this.label9.TabIndex = 1;
            this.label9.Text = "Subnet Calculator";
            // 
            // SubnetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.Untitled_design_16_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Name = "SubnetForm";
            this.Text = "SubnetForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox broadcastAddress_textBox;
        private System.Windows.Forms.TextBox lastUseable_textBox;
        private System.Windows.Forms.TextBox firstUseable_textBox;
        private System.Windows.Forms.TextBox cidrNotat;
        private System.Windows.Forms.TextBox networkAddress_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oct_four;
        private System.Windows.Forms.TextBox oct_three;
        private System.Windows.Forms.TextBox oct_two;
        private System.Windows.Forms.TextBox oct_one;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}