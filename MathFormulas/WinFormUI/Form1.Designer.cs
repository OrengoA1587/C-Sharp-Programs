
namespace WinFormUI
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
            this.slope_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.areaCircle_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.areaTriangle_button = new System.Windows.Forms.Button();
            this.area_SquRec_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slope_button
            // 
            this.slope_button.BackColor = System.Drawing.Color.Lime;
            this.slope_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slope_button.Location = new System.Drawing.Point(83, 288);
            this.slope_button.Name = "slope_button";
            this.slope_button.Size = new System.Drawing.Size(193, 40);
            this.slope_button.TabIndex = 0;
            this.slope_button.Text = "Slope Formula";
            this.slope_button.UseVisualStyleBackColor = false;
            this.slope_button.Click += new System.EventHandler(this.slopebutton1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(83, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pythagorean Theorem";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // areaCircle_button
            // 
            this.areaCircle_button.BackColor = System.Drawing.Color.Lime;
            this.areaCircle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaCircle_button.Location = new System.Drawing.Point(83, 82);
            this.areaCircle_button.Name = "areaCircle_button";
            this.areaCircle_button.Size = new System.Drawing.Size(253, 40);
            this.areaCircle_button.TabIndex = 2;
            this.areaCircle_button.Text = "Area of Circle";
            this.areaCircle_button.UseVisualStyleBackColor = false;
            this.areaCircle_button.Click += new System.EventHandler(this.areaCircle_button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(83, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Slope Formula";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // areaTriangle_button
            // 
            this.areaTriangle_button.BackColor = System.Drawing.Color.Lime;
            this.areaTriangle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTriangle_button.Location = new System.Drawing.Point(83, 128);
            this.areaTriangle_button.Name = "areaTriangle_button";
            this.areaTriangle_button.Size = new System.Drawing.Size(253, 40);
            this.areaTriangle_button.TabIndex = 4;
            this.areaTriangle_button.Text = "Area of Triangle";
            this.areaTriangle_button.UseVisualStyleBackColor = false;
            this.areaTriangle_button.Click += new System.EventHandler(this.areaTriangle_button_Click);
            // 
            // area_SquRec_button
            // 
            this.area_SquRec_button.BackColor = System.Drawing.Color.Lime;
            this.area_SquRec_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area_SquRec_button.Location = new System.Drawing.Point(83, 174);
            this.area_SquRec_button.Name = "area_SquRec_button";
            this.area_SquRec_button.Size = new System.Drawing.Size(253, 40);
            this.area_SquRec_button.TabIndex = 5;
            this.area_SquRec_button.Text = "Area of Square/Rectangle";
            this.area_SquRec_button.UseVisualStyleBackColor = false;
            this.area_SquRec_button.Click += new System.EventHandler(this.area_SquRec_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "MATH FORMULAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.createAccountToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createAccountToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // createAccountToolStripMenuItem1
            // 
            this.createAccountToolStripMenuItem1.Name = "createAccountToolStripMenuItem1";
            this.createAccountToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.createAccountToolStripMenuItem1.Text = "Create Account";
            this.createAccountToolStripMenuItem1.Click += new System.EventHandler(this.createAccountToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.Main_Image;
            this.ClientSize = new System.Drawing.Size(1026, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.area_SquRec_button);
            this.Controls.Add(this.areaTriangle_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.areaCircle_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.slope_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button slope_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button areaCircle_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button areaTriangle_button;
        private System.Windows.Forms.Button area_SquRec_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

