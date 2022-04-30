
namespace ConsoleUI
{
    partial class MainMenu
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
            this.startAdventure_button = new System.Windows.Forms.Button();
            this.continueAdventure_button = new System.Windows.Forms.Button();
            this.playerStat_button = new System.Windows.Forms.Button();
            this.setting_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startAdventure_button
            // 
            this.startAdventure_button.BackColor = System.Drawing.Color.White;
            this.startAdventure_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startAdventure_button.FlatAppearance.BorderSize = 2;
            this.startAdventure_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.startAdventure_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startAdventure_button.Font = new System.Drawing.Font("Microsoft Himalaya", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAdventure_button.ForeColor = System.Drawing.Color.Red;
            this.startAdventure_button.Location = new System.Drawing.Point(204, 180);
            this.startAdventure_button.Name = "startAdventure_button";
            this.startAdventure_button.Size = new System.Drawing.Size(339, 59);
            this.startAdventure_button.TabIndex = 0;
            this.startAdventure_button.Text = "Start New Adventure";
            this.startAdventure_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startAdventure_button.UseVisualStyleBackColor = false;
            this.startAdventure_button.Click += new System.EventHandler(this.startAdventure_button_Click);
            this.startAdventure_button.MouseLeave += new System.EventHandler(this.startAdv_MouseLeave);
            this.startAdventure_button.MouseHover += new System.EventHandler(this.startAdv_MouseHover);
            // 
            // continueAdventure_button
            // 
            this.continueAdventure_button.BackColor = System.Drawing.Color.White;
            this.continueAdventure_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.continueAdventure_button.FlatAppearance.BorderSize = 2;
            this.continueAdventure_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.continueAdventure_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueAdventure_button.Font = new System.Drawing.Font("Microsoft Himalaya", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueAdventure_button.Location = new System.Drawing.Point(204, 237);
            this.continueAdventure_button.Name = "continueAdventure_button";
            this.continueAdventure_button.Size = new System.Drawing.Size(339, 60);
            this.continueAdventure_button.TabIndex = 1;
            this.continueAdventure_button.Text = "Continue Adventure";
            this.continueAdventure_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.continueAdventure_button.UseVisualStyleBackColor = false;
            this.continueAdventure_button.Click += new System.EventHandler(this.continueAdventure_button_Click);
            // 
            // playerStat_button
            // 
            this.playerStat_button.BackColor = System.Drawing.Color.White;
            this.playerStat_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.playerStat_button.FlatAppearance.BorderSize = 2;
            this.playerStat_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.playerStat_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerStat_button.Font = new System.Drawing.Font("Microsoft Himalaya", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerStat_button.Location = new System.Drawing.Point(204, 293);
            this.playerStat_button.Name = "playerStat_button";
            this.playerStat_button.Size = new System.Drawing.Size(339, 60);
            this.playerStat_button.TabIndex = 2;
            this.playerStat_button.Text = "Player Stats";
            this.playerStat_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.playerStat_button.UseVisualStyleBackColor = false;
            // 
            // setting_button
            // 
            this.setting_button.BackColor = System.Drawing.Color.White;
            this.setting_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.setting_button.FlatAppearance.BorderSize = 2;
            this.setting_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.setting_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_button.Font = new System.Drawing.Font("Microsoft Himalaya", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_button.Location = new System.Drawing.Point(204, 349);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(339, 60);
            this.setting_button.TabIndex = 3;
            this.setting_button.Text = "Settings";
            this.setting_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.setting_button.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 96);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adventures in Zombie World";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.White;
            this.exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_button.FlatAppearance.BorderSize = 2;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Himalaya", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit_button.Location = new System.Drawing.Point(204, 406);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(339, 60);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Exit";
            this.exit_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleUI.Properties.Resources.ZombieImageBG2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1121, 754);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setting_button);
            this.Controls.Add(this.playerStat_button);
            this.Controls.Add(this.continueAdventure_button);
            this.Controls.Add(this.startAdventure_button);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startAdventure_button;
        private System.Windows.Forms.Button continueAdventure_button;
        private System.Windows.Forms.Button playerStat_button;
        private System.Windows.Forms.Button setting_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit_button;
    }
}