
namespace ConsoleUI
{
    partial class StartForm
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
            this.start_button = new System.Windows.Forms.Button();
            this.start_progressBar = new System.Windows.Forms.ProgressBar();
            this.enter_button = new System.Windows.Forms.Button();
            this.timer_load = new System.Windows.Forms.Timer(this.components);
            this.title_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.SystemColors.ControlText;
            this.start_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.start_button.FlatAppearance.BorderSize = 3;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.start_button.Location = new System.Drawing.Point(945, 504);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(97, 38);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // start_progressBar
            // 
            this.start_progressBar.Location = new System.Drawing.Point(775, 558);
            this.start_progressBar.Name = "start_progressBar";
            this.start_progressBar.Size = new System.Drawing.Size(446, 34);
            this.start_progressBar.TabIndex = 2;
            this.start_progressBar.Visible = false;
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.Red;
            this.enter_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.enter_button.FlatAppearance.BorderSize = 3;
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.enter_button.Location = new System.Drawing.Point(945, 504);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(97, 38);
            this.enter_button.TabIndex = 3;
            this.enter_button.Text = "Enter";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Visible = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            this.enter_button.MouseLeave += new System.EventHandler(this.enterButton_Leave);
            this.enter_button.MouseHover += new System.EventHandler(this.enterButton_Hover);
            // 
            // timer_load
            // 
            this.timer_load.Tick += new System.EventHandler(this.timer_load_Tick);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Microsoft Himalaya", 125.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.title_label.Location = new System.Drawing.Point(272, 279);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(1395, 167);
            this.title_label.TabIndex = 4;
            this.title_label.Text = "Adventures in Zombie World";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleUI.Properties.Resources.ZombieImageBG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1968, 785);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.start_progressBar);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.enter_button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.ProgressBar start_progressBar;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Timer timer_load;
        private System.Windows.Forms.Label title_label;
    }
}