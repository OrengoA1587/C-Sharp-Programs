
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
            this.encrypt_button = new System.Windows.Forms.Button();
            this.PlainText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plainText_textBox = new System.Windows.Forms.TextBox();
            this.encryptedText_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encrypt_button
            // 
            this.encrypt_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.encrypt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_button.Location = new System.Drawing.Point(473, 373);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(85, 33);
            this.encrypt_button.TabIndex = 0;
            this.encrypt_button.Text = "Encrypt";
            this.encrypt_button.UseVisualStyleBackColor = false;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // PlainText
            // 
            this.PlainText.AutoSize = true;
            this.PlainText.BackColor = System.Drawing.Color.Transparent;
            this.PlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainText.ForeColor = System.Drawing.Color.Gold;
            this.PlainText.Location = new System.Drawing.Point(25, 187);
            this.PlainText.Name = "PlainText";
            this.PlainText.Size = new System.Drawing.Size(87, 20);
            this.PlainText.TabIndex = 1;
            this.PlainText.Text = "Plain Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(25, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encypted Text";
            // 
            // plainText_textBox
            // 
            this.plainText_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainText_textBox.Location = new System.Drawing.Point(154, 149);
            this.plainText_textBox.Multiline = true;
            this.plainText_textBox.Name = "plainText_textBox";
            this.plainText_textBox.Size = new System.Drawing.Size(404, 98);
            this.plainText_textBox.TabIndex = 3;
            // 
            // encryptedText_textBox
            // 
            this.encryptedText_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedText_textBox.Location = new System.Drawing.Point(154, 253);
            this.encryptedText_textBox.Multiline = true;
            this.encryptedText_textBox.Name = "encryptedText_textBox";
            this.encryptedText_textBox.Size = new System.Drawing.Size(404, 100);
            this.encryptedText_textBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(147, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "SHA-512 Encryption";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.MainFormImage;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptedText_textBox);
            this.Controls.Add(this.plainText_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainText);
            this.Controls.Add(this.encrypt_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Label PlainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plainText_textBox;
        private System.Windows.Forms.TextBox encryptedText_textBox;
        private System.Windows.Forms.Label label2;
    }
}

