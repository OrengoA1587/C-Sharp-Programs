
namespace WinFormUI
{
    partial class AreaOfCircle
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
            this.label2 = new System.Windows.Forms.Label();
            this.radius_textBox = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.diameter_textBox = new System.Windows.Forms.TextBox();
            this.Circum_textBox = new System.Windows.Forms.TextBox();
            this.area_textBox = new System.Windows.Forms.TextBox();
            this.area_textBox2 = new System.Windows.Forms.TextBox();
            this.diameter_textBox2 = new System.Windows.Forms.TextBox();
            this.circum_textBox2 = new System.Windows.Forms.TextBox();
            this.Short_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Circle Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area";
            // 
            // radius_textBox
            // 
            this.radius_textBox.Location = new System.Drawing.Point(201, 134);
            this.radius_textBox.Name = "radius_textBox";
            this.radius_textBox.Size = new System.Drawing.Size(94, 20);
            this.radius_textBox.TabIndex = 2;
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_button.Location = new System.Drawing.Point(197, 404);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(84, 27);
            this.calculate_button.TabIndex = 3;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click_1);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.Location = new System.Drawing.Point(49, 404);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(77, 27);
            this.Clear_Button.TabIndex = 5;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Diameter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Circumference";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter Radius";
            // 
            // diameter_textBox
            // 
            this.diameter_textBox.Location = new System.Drawing.Point(254, 248);
            this.diameter_textBox.Name = "diameter_textBox";
            this.diameter_textBox.Size = new System.Drawing.Size(196, 20);
            this.diameter_textBox.TabIndex = 9;
            // 
            // Circum_textBox
            // 
            this.Circum_textBox.Location = new System.Drawing.Point(254, 315);
            this.Circum_textBox.Name = "Circum_textBox";
            this.Circum_textBox.Size = new System.Drawing.Size(196, 20);
            this.Circum_textBox.TabIndex = 10;
            // 
            // area_textBox
            // 
            this.area_textBox.Location = new System.Drawing.Point(254, 185);
            this.area_textBox.Name = "area_textBox";
            this.area_textBox.Size = new System.Drawing.Size(196, 20);
            this.area_textBox.TabIndex = 11;
            // 
            // area_textBox2
            // 
            this.area_textBox2.Location = new System.Drawing.Point(254, 215);
            this.area_textBox2.Name = "area_textBox2";
            this.area_textBox2.Size = new System.Drawing.Size(196, 20);
            this.area_textBox2.TabIndex = 12;
            // 
            // diameter_textBox2
            // 
            this.diameter_textBox2.Location = new System.Drawing.Point(254, 281);
            this.diameter_textBox2.Name = "diameter_textBox2";
            this.diameter_textBox2.Size = new System.Drawing.Size(196, 20);
            this.diameter_textBox2.TabIndex = 13;
            // 
            // circum_textBox2
            // 
            this.circum_textBox2.Location = new System.Drawing.Point(254, 352);
            this.circum_textBox2.Name = "circum_textBox2";
            this.circum_textBox2.Size = new System.Drawing.Size(196, 20);
            this.circum_textBox2.TabIndex = 14;
            // 
            // Short_label
            // 
            this.Short_label.AutoSize = true;
            this.Short_label.Location = new System.Drawing.Point(208, 218);
            this.Short_label.Name = "Short_label";
            this.Short_label.Size = new System.Drawing.Size(32, 13);
            this.Short_label.TabIndex = 15;
            this.Short_label.Text = "Short";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Long";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Long";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Short";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Short";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Long";
            // 
            // AreaOfCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 478);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Short_label);
            this.Controls.Add(this.circum_textBox2);
            this.Controls.Add(this.diameter_textBox2);
            this.Controls.Add(this.area_textBox2);
            this.Controls.Add(this.area_textBox);
            this.Controls.Add(this.Circum_textBox);
            this.Controls.Add(this.diameter_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.radius_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AreaOfCircle";
            this.Text = "AreaOfSquareRec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox radius_textBox;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diameter_textBox;
        private System.Windows.Forms.TextBox Circum_textBox;
        private System.Windows.Forms.TextBox area_textBox;
        private System.Windows.Forms.TextBox area_textBox2;
        private System.Windows.Forms.TextBox diameter_textBox2;
        private System.Windows.Forms.TextBox circum_textBox2;
        private System.Windows.Forms.Label Short_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}