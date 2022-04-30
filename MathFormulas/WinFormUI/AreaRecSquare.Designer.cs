
namespace WinFormUI
{
    partial class AreaRecSquare
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
            this.label3 = new System.Windows.Forms.Label();
            this.length_textBox1 = new System.Windows.Forms.TextBox();
            this.width_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.answer_textBox1 = new System.Windows.Forms.TextBox();
            this.calculate_AreaTriangle_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.startOver_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area of Square/Rectangle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input Width";
            // 
            // length_textBox1
            // 
            this.length_textBox1.Location = new System.Drawing.Point(223, 81);
            this.length_textBox1.Name = "length_textBox1";
            this.length_textBox1.Size = new System.Drawing.Size(100, 20);
            this.length_textBox1.TabIndex = 3;
            // 
            // width_textBox1
            // 
            this.width_textBox1.Location = new System.Drawing.Point(223, 128);
            this.width_textBox1.Name = "width_textBox1";
            this.width_textBox1.Size = new System.Drawing.Size(100, 20);
            this.width_textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Answer";
            // 
            // answer_textBox1
            // 
            this.answer_textBox1.Location = new System.Drawing.Point(223, 230);
            this.answer_textBox1.Name = "answer_textBox1";
            this.answer_textBox1.Size = new System.Drawing.Size(100, 20);
            this.answer_textBox1.TabIndex = 6;
            // 
            // calculate_AreaTriangle_button
            // 
            this.calculate_AreaTriangle_button.Location = new System.Drawing.Point(57, 188);
            this.calculate_AreaTriangle_button.Name = "calculate_AreaTriangle_button";
            this.calculate_AreaTriangle_button.Size = new System.Drawing.Size(75, 23);
            this.calculate_AreaTriangle_button.TabIndex = 7;
            this.calculate_AreaTriangle_button.Text = "Calculate";
            this.calculate_AreaTriangle_button.UseVisualStyleBackColor = true;
            this.calculate_AreaTriangle_button.Click += new System.EventHandler(this.calculate_AreaTriangle_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(248, 256);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 8;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Visible = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // startOver_label
            // 
            this.startOver_label.AutoSize = true;
            this.startOver_label.Location = new System.Drawing.Point(187, 261);
            this.startOver_label.Name = "startOver_label";
            this.startOver_label.Size = new System.Drawing.Size(55, 13);
            this.startOver_label.TabIndex = 9;
            this.startOver_label.Text = "Start Over";
            this.startOver_label.Visible = false;
            // 
            // AreaRecSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 357);
            this.Controls.Add(this.startOver_label);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.calculate_AreaTriangle_button);
            this.Controls.Add(this.answer_textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.width_textBox1);
            this.Controls.Add(this.length_textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AreaRecSquare";
            this.Text = "AreaCircleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox length_textBox1;
        private System.Windows.Forms.TextBox width_textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox answer_textBox1;
        private System.Windows.Forms.Button calculate_AreaTriangle_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label startOver_label;
    }
}