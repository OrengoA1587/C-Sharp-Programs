
namespace WinFormUI
{
    partial class EmployeeDashboard_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subnetCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subnetCalculatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitCalculatorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.go_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.forward_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.url_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cisco_webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cisco Dashboard";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.calculatorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 29);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // calculatorsToolStripMenuItem
            // 
            this.calculatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subnetCalculatorToolStripMenuItem,
            this.subnetCalculatorToolStripMenuItem1,
            this.bitCalculatorToolStripMenuItem2});
            this.calculatorsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorsToolStripMenuItem.Name = "calculatorsToolStripMenuItem";
            this.calculatorsToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.calculatorsToolStripMenuItem.Text = "Calculators";
            // 
            // subnetCalculatorToolStripMenuItem
            // 
            this.subnetCalculatorToolStripMenuItem.Name = "subnetCalculatorToolStripMenuItem";
            this.subnetCalculatorToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.subnetCalculatorToolStripMenuItem.Text = "Subnet Calculator";
            this.subnetCalculatorToolStripMenuItem.Click += new System.EventHandler(this.subnetCalculatorToolStripMenuItem_Click);
            // 
            // subnetCalculatorToolStripMenuItem1
            // 
            this.subnetCalculatorToolStripMenuItem1.Name = "subnetCalculatorToolStripMenuItem1";
            this.subnetCalculatorToolStripMenuItem1.Size = new System.Drawing.Size(237, 30);
            this.subnetCalculatorToolStripMenuItem1.Text = "Host Calculator";
            this.subnetCalculatorToolStripMenuItem1.Click += new System.EventHandler(this.hostCalculatorToolStripMenuItem1_Click);
            // 
            // bitCalculatorToolStripMenuItem2
            // 
            this.bitCalculatorToolStripMenuItem2.Name = "bitCalculatorToolStripMenuItem2";
            this.bitCalculatorToolStripMenuItem2.Size = new System.Drawing.Size(237, 30);
            this.bitCalculatorToolStripMenuItem2.Text = "Bits Calculator";
            this.bitCalculatorToolStripMenuItem2.Click += new System.EventHandler(this.bitCalculatorToolStripMenuItem2_Click_1);
            // 
            // go_button
            // 
            this.go_button.BackColor = System.Drawing.Color.Transparent;
            this.go_button.BackgroundImage = global::WinFormUI.Properties.Resources.Untitled_design_8_;
            this.go_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.go_button.FlatAppearance.BorderSize = 0;
            this.go_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go_button.Location = new System.Drawing.Point(818, 3);
            this.go_button.Name = "go_button";
            this.go_button.Size = new System.Drawing.Size(30, 30);
            this.go_button.TabIndex = 16;
            this.go_button.Text = " ";
            this.go_button.UseVisualStyleBackColor = false;
            this.go_button.Click += new System.EventHandler(this.go_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter URL";
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.Transparent;
            this.refresh_button.BackgroundImage = global::WinFormUI.Properties.Resources.Untitled_design_9_;
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.FlatAppearance.BorderSize = 0;
            this.refresh_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_button.Location = new System.Drawing.Point(773, 3);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(30, 30);
            this.refresh_button.TabIndex = 14;
            this.refresh_button.Text = " ";
            this.refresh_button.UseVisualStyleBackColor = false;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // forward_button
            // 
            this.forward_button.BackColor = System.Drawing.Color.Transparent;
            this.forward_button.BackgroundImage = global::WinFormUI.Properties.Resources.Untitled_design_7_;
            this.forward_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forward_button.FlatAppearance.BorderSize = 0;
            this.forward_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forward_button.Location = new System.Drawing.Point(723, 3);
            this.forward_button.Name = "forward_button";
            this.forward_button.Size = new System.Drawing.Size(30, 30);
            this.forward_button.TabIndex = 13;
            this.forward_button.Text = " ";
            this.forward_button.UseVisualStyleBackColor = false;
            this.forward_button.Click += new System.EventHandler(this.forward_button_Click);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BackgroundImage = global::WinFormUI.Properties.Resources.Untitled_design_2_;
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Location = new System.Drawing.Point(677, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(30, 30);
            this.back_button.TabIndex = 12;
            this.back_button.Text = " ";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // url_textBox
            // 
            this.url_textBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.url_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url_textBox.Location = new System.Drawing.Point(113, 8);
            this.url_textBox.Name = "url_textBox";
            this.url_textBox.Size = new System.Drawing.Size(558, 27);
            this.url_textBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinFormUI.Properties.Resources.CiscoLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1068, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cisco_webBrowser
            // 
            this.cisco_webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cisco_webBrowser.Location = new System.Drawing.Point(0, 0);
            this.cisco_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.cisco_webBrowser.Name = "cisco_webBrowser";
            this.cisco_webBrowser.Size = new System.Drawing.Size(1885, 607);
            this.cisco_webBrowser.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cisco_webBrowser);
            this.panel1.Location = new System.Drawing.Point(35, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1889, 611);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.go_button);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.refresh_button);
            this.panel2.Controls.Add(this.forward_button);
            this.panel2.Controls.Add(this.url_textBox);
            this.panel2.Controls.Add(this.back_button);
            this.panel2.Location = new System.Drawing.Point(35, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1889, 41);
            this.panel2.TabIndex = 17;
            // 
            // EmployeeDashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.Untitled_design_16_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 851);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeDashboard_Form";
            this.Text = "EmployeeDashboard_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button forward_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox url_textBox;
        private System.Windows.Forms.Button go_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem calculatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subnetCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subnetCalculatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bitCalculatorToolStripMenuItem2;
        private System.Windows.Forms.WebBrowser cisco_webBrowser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}