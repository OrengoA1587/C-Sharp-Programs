
namespace ConsoleUI
{
    partial class StartAdventureForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.start_button = new System.Windows.Forms.Button();
            this.enter_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(580, 542);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(633, 23);
            this.progressBar.TabIndex = 0;
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.LightSlateGray;
            this.start_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.start_button.FlatAppearance.BorderSize = 3;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(839, 613);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(97, 38);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // enter_Button
            // 
            this.enter_Button.BackColor = System.Drawing.Color.LightSlateGray;
            this.enter_Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.enter_Button.FlatAppearance.BorderSize = 3;
            this.enter_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_Button.Location = new System.Drawing.Point(839, 613);
            this.enter_Button.Name = "enter_Button";
            this.enter_Button.Size = new System.Drawing.Size(97, 38);
            this.enter_Button.TabIndex = 3;
            this.enter_Button.Text = "Enter";
            this.enter_Button.UseVisualStyleBackColor = false;
            this.enter_Button.Click += new System.EventHandler(this.enter_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(362, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1118, 133);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adventures in Zombie World";
            // 
            // StartAdventureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleUI.Properties.Resources.ZombieImageBG3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1623, 844);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.enter_Button);
            this.DoubleBuffered = true;
            this.Name = "StartAdventureForm";
            this.Text = "StartAdventureForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button enter_Button;
        private System.Windows.Forms.Label label2;
    }
}