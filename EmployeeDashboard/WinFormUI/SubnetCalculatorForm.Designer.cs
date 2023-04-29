
namespace WinFormUI
{
    partial class SubnetCalculatorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.Label();
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.subnet_textBox = new System.Windows.Forms.TextBox();
            this.hostBits_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hosts_textBox = new System.Windows.Forms.TextBox();
            this.hostsNeededtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateHostsNeeded_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total  Subnets";
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.BackColor = System.Drawing.Color.Transparent;
            this.Host.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Host.Location = new System.Drawing.Point(12, 97);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(78, 18);
            this.Host.TabIndex = 12;
            this.Host.Text = "Host Bits";
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorButton.Location = new System.Drawing.Point(203, 125);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(75, 23);
            this.CalculatorButton.TabIndex = 11;
            this.CalculatorButton.Text = "Calculate";
            this.CalculatorButton.UseVisualStyleBackColor = true;
            this.CalculatorButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // subnet_textBox
            // 
            this.subnet_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnet_textBox.Location = new System.Drawing.Point(135, 171);
            this.subnet_textBox.Name = "subnet_textBox";
            this.subnet_textBox.Size = new System.Drawing.Size(144, 29);
            this.subnet_textBox.TabIndex = 10;
            // 
            // hostBits_textBox
            // 
            this.hostBits_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostBits_textBox.Location = new System.Drawing.Point(134, 90);
            this.hostBits_textBox.Name = "hostBits_textBox";
            this.hostBits_textBox.Size = new System.Drawing.Size(144, 29);
            this.hostBits_textBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subnet Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinFormUI.Properties.Resources.CiscoLogo;
            this.pictureBox1.Location = new System.Drawing.Point(264, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 52);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total  Subnets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hosts";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(158, 338);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 29);
            this.textBox1.TabIndex = 17;
            // 
            // hosts_textBox
            // 
            this.hosts_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hosts_textBox.Location = new System.Drawing.Point(158, 268);
            this.hosts_textBox.Name = "hosts_textBox";
            this.hosts_textBox.Size = new System.Drawing.Size(144, 29);
            this.hosts_textBox.TabIndex = 18;
            // 
            // hostsNeededtextBox
            // 
            this.hostsNeededtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostsNeededtextBox.Location = new System.Drawing.Point(158, 303);
            this.hostsNeededtextBox.Name = "hostsNeededtextBox";
            this.hostsNeededtextBox.Size = new System.Drawing.Size(144, 29);
            this.hostsNeededtextBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Host Bits Needed";
            // 
            // CalculateHostsNeeded_Button
            // 
            this.CalculateHostsNeeded_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateHostsNeeded_Button.Location = new System.Drawing.Point(227, 373);
            this.CalculateHostsNeeded_Button.Name = "CalculateHostsNeeded_Button";
            this.CalculateHostsNeeded_Button.Size = new System.Drawing.Size(75, 23);
            this.CalculateHostsNeeded_Button.TabIndex = 21;
            this.CalculateHostsNeeded_Button.Text = "Calculate";
            this.CalculateHostsNeeded_Button.UseVisualStyleBackColor = true;
            this.CalculateHostsNeeded_Button.Click += new System.EventHandler(this.CalculateHostsNeeded_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Host Bit Calculator";
            // 
            // SubnetCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.Untitled_design_16_;
            this.ClientSize = new System.Drawing.Size(374, 446);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CalculateHostsNeeded_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hostsNeededtextBox);
            this.Controls.Add(this.hosts_textBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.CalculatorButton);
            this.Controls.Add(this.subnet_textBox);
            this.Controls.Add(this.hostBits_textBox);
            this.Controls.Add(this.label1);
            this.Name = "SubnetCalculatorForm";
            this.Text = "SubnetCalculatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.Button CalculatorButton;
        private System.Windows.Forms.TextBox subnet_textBox;
        private System.Windows.Forms.TextBox hostBits_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox hosts_textBox;
        private System.Windows.Forms.TextBox hostsNeededtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateHostsNeeded_Button;
        private System.Windows.Forms.Label label6;
    }
}