namespace WinformUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.on_button = new System.Windows.Forms.Button();
            this.off_button = new System.Windows.Forms.Button();
            this.displayCode_textBox = new System.Windows.Forms.TextBox();
            this.decode_textBox = new System.Windows.Forms.TextBox();
            this.send_button = new System.Windows.Forms.Button();
            this.space_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.completedMessage_textBox = new System.Windows.Forms.TextBox();
            this.complete_button = new System.Windows.Forms.Button();
            this.resetCompleteTextBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // on_button
            // 
            this.on_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.on_button.FlatAppearance.BorderSize = 3;
            this.on_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.on_button.Font = new System.Drawing.Font("Microsoft Himalaya", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.on_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.on_button.Location = new System.Drawing.Point(73, 262);
            this.on_button.Name = "on_button";
            this.on_button.Size = new System.Drawing.Size(188, 99);
            this.on_button.TabIndex = 0;
            this.on_button.Text = "ON";
            this.on_button.UseVisualStyleBackColor = false;
            this.on_button.Click += new System.EventHandler(this.on_button_Click);
            this.on_button.MouseLeave += new System.EventHandler(this.on_button_MouseLeave);
            this.on_button.MouseHover += new System.EventHandler(this.on_button_MouseHover);
            // 
            // off_button
            // 
            this.off_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.off_button.FlatAppearance.BorderSize = 3;
            this.off_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.off_button.Font = new System.Drawing.Font("Microsoft Himalaya", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.off_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.off_button.Location = new System.Drawing.Point(461, 262);
            this.off_button.Name = "off_button";
            this.off_button.Size = new System.Drawing.Size(188, 99);
            this.off_button.TabIndex = 1;
            this.off_button.Text = "OFF";
            this.off_button.UseVisualStyleBackColor = false;
            this.off_button.Click += new System.EventHandler(this.off_button_Click);
            this.off_button.MouseLeave += new System.EventHandler(this.off_button_MouseLeave);
            this.off_button.MouseHover += new System.EventHandler(this.off_button_MouseHover);
            // 
            // displayCode_textBox
            // 
            this.displayCode_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCode_textBox.Location = new System.Drawing.Point(669, 124);
            this.displayCode_textBox.Multiline = true;
            this.displayCode_textBox.Name = "displayCode_textBox";
            this.displayCode_textBox.Size = new System.Drawing.Size(357, 347);
            this.displayCode_textBox.TabIndex = 2;
            // 
            // decode_textBox
            // 
            this.decode_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decode_textBox.Location = new System.Drawing.Point(73, 477);
            this.decode_textBox.Multiline = true;
            this.decode_textBox.Name = "decode_textBox";
            this.decode_textBox.Size = new System.Drawing.Size(382, 269);
            this.decode_textBox.TabIndex = 3;
            this.decode_textBox.TextChanged += new System.EventHandler(this.decode_textBox_TextChanged);
            // 
            // send_button
            // 
            this.send_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.send_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.send_button.FlatAppearance.BorderSize = 3;
            this.send_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_button.Font = new System.Drawing.Font("Microsoft Himalaya", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.send_button.Location = new System.Drawing.Point(73, 373);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(188, 79);
            this.send_button.TabIndex = 4;
            this.send_button.Text = "Send";
            this.send_button.UseVisualStyleBackColor = false;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            this.send_button.MouseLeave += new System.EventHandler(this.send_button_MouseLeave);
            this.send_button.MouseHover += new System.EventHandler(this.send_button_MouseHover);
            // 
            // space_button
            // 
            this.space_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.space_button.FlatAppearance.BorderSize = 3;
            this.space_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.space_button.Font = new System.Drawing.Font("Microsoft Himalaya", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.space_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.space_button.Location = new System.Drawing.Point(267, 262);
            this.space_button.Name = "space_button";
            this.space_button.Size = new System.Drawing.Size(188, 99);
            this.space_button.TabIndex = 6;
            this.space_button.Text = "BREAK";
            this.space_button.UseVisualStyleBackColor = false;
            this.space_button.Click += new System.EventHandler(this.space_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reset_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reset_button.FlatAppearance.BorderSize = 3;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_button.Font = new System.Drawing.Font("Microsoft Himalaya", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reset_button.Location = new System.Drawing.Point(461, 373);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(188, 82);
            this.reset_button.TabIndex = 7;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            this.reset_button.MouseLeave += new System.EventHandler(this.reset_button_MouseLeave);
            this.reset_button.MouseHover += new System.EventHandler(this.reset_button_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1032, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 683);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 96);
            this.label1.TabIndex = 9;
            this.label1.Text = "MORSE CODE DECODER";
            // 
            // completedMessage_textBox
            // 
            this.completedMessage_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedMessage_textBox.Location = new System.Drawing.Point(461, 477);
            this.completedMessage_textBox.Multiline = true;
            this.completedMessage_textBox.Name = "completedMessage_textBox";
            this.completedMessage_textBox.Size = new System.Drawing.Size(564, 269);
            this.completedMessage_textBox.TabIndex = 10;
            // 
            // complete_button
            // 
            this.complete_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.complete_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.complete_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.complete_button.Font = new System.Drawing.Font("Microsoft Himalaya", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complete_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.complete_button.Location = new System.Drawing.Point(461, 752);
            this.complete_button.Name = "complete_button";
            this.complete_button.Size = new System.Drawing.Size(210, 79);
            this.complete_button.TabIndex = 11;
            this.complete_button.Text = "Complete";
            this.complete_button.UseVisualStyleBackColor = false;
            this.complete_button.Click += new System.EventHandler(this.complete_button_Click);
            this.complete_button.MouseLeave += new System.EventHandler(this.complete_button_MouseLeave);
            this.complete_button.MouseHover += new System.EventHandler(this.complete_button_MouseHover);
            // 
            // resetCompleteTextBox
            // 
            this.resetCompleteTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resetCompleteTextBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetCompleteTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetCompleteTextBox.Font = new System.Drawing.Font("Microsoft Himalaya", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetCompleteTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetCompleteTextBox.Location = new System.Drawing.Point(837, 750);
            this.resetCompleteTextBox.Name = "resetCompleteTextBox";
            this.resetCompleteTextBox.Size = new System.Drawing.Size(188, 82);
            this.resetCompleteTextBox.TabIndex = 12;
            this.resetCompleteTextBox.Text = "Reset";
            this.resetCompleteTextBox.UseVisualStyleBackColor = false;
            this.resetCompleteTextBox.Click += new System.EventHandler(this.resetCompleteTextBox_Click);
            this.resetCompleteTextBox.MouseLeave += new System.EventHandler(this.resetCompleteTextBox_MouseLeave);
            this.resetCompleteTextBox.MouseHover += new System.EventHandler(this.resetCompleteTextBox_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1585, 914);
            this.Controls.Add(this.resetCompleteTextBox);
            this.Controls.Add(this.complete_button);
            this.Controls.Add(this.completedMessage_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.space_button);
            this.Controls.Add(this.send_button);
            this.Controls.Add(this.decode_textBox);
            this.Controls.Add(this.displayCode_textBox);
            this.Controls.Add(this.off_button);
            this.Controls.Add(this.on_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button on_button;
        private System.Windows.Forms.Button off_button;
        private System.Windows.Forms.TextBox displayCode_textBox;
        private System.Windows.Forms.TextBox decode_textBox;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button space_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox completedMessage_textBox;
        private System.Windows.Forms.Button complete_button;
        private System.Windows.Forms.Button resetCompleteTextBox;
    }
}

