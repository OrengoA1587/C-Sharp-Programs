
namespace WinformUI
{
    partial class MainForm
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
            this.SHA_button = new System.Windows.Forms.Button();
            this.AES_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(232, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption Program";
            // 
            // SHA_button
            // 
            this.SHA_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SHA_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA_button.Location = new System.Drawing.Point(239, 451);
            this.SHA_button.Name = "SHA_button";
            this.SHA_button.Size = new System.Drawing.Size(85, 39);
            this.SHA_button.TabIndex = 2;
            this.SHA_button.Text = "SHA";
            this.SHA_button.UseVisualStyleBackColor = false;
            this.SHA_button.Click += new System.EventHandler(this.SHA_button_Click);
            // 
            // AES_button
            // 
            this.AES_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AES_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AES_button.Location = new System.Drawing.Point(239, 406);
            this.AES_button.Name = "AES_button";
            this.AES_button.Size = new System.Drawing.Size(85, 39);
            this.AES_button.TabIndex = 3;
            this.AES_button.Text = "AES";
            this.AES_button.UseVisualStyleBackColor = false;
            this.AES_button.Click += new System.EventHandler(this.AES_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinformUI.Properties.Resources.EncryptImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 539);
            this.Controls.Add(this.AES_button);
            this.Controls.Add(this.SHA_button);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SHA_button;
        private System.Windows.Forms.Button AES_button;
    }
}