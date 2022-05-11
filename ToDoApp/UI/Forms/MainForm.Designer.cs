namespace ToDoApp.Forms
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new ToDoApp.UI.Controls.RoundButton();
            this.tasksButton = new ToDoApp.UI.Controls.RoundButton();
            this.homeButton = new ToDoApp.UI.Controls.RoundButton();
            this.exitButton = new ToDoApp.UI.Controls.RoundButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.menuPanel.Controls.Add(this.settingsButton);
            this.menuPanel.Controls.Add(this.tasksButton);
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(183, 606);
            this.menuPanel.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.settingsButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.settingsButton.BorderColor = System.Drawing.Color.Empty;
            this.settingsButton.BorderRadius = 1;
            this.settingsButton.BorderSize = 0;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.settingsButton.IconColor = System.Drawing.Color.Black;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IsLoggingEnabled = true;
            this.settingsButton.Location = new System.Drawing.Point(0, 118);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(183, 59);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // tasksButton
            // 
            this.tasksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.tasksButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.tasksButton.BorderColor = System.Drawing.Color.Empty;
            this.tasksButton.BorderRadius = 1;
            this.tasksButton.BorderSize = 0;
            this.tasksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tasksButton.FlatAppearance.BorderSize = 0;
            this.tasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasksButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tasksButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tasksButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tasksButton.IconColor = System.Drawing.Color.Black;
            this.tasksButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tasksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tasksButton.IsLoggingEnabled = true;
            this.tasksButton.Location = new System.Drawing.Point(0, 59);
            this.tasksButton.Name = "tasksButton";
            this.tasksButton.Size = new System.Drawing.Size(183, 59);
            this.tasksButton.TabIndex = 3;
            this.tasksButton.Text = "Tasks";
            this.tasksButton.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tasksButton.UseVisualStyleBackColor = false;
            this.tasksButton.Click += new System.EventHandler(this.tasksButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.homeButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.homeButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.homeButton.BorderRadius = 1;
            this.homeButton.BorderSize = 0;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.homeButton.IconColor = System.Drawing.Color.Black;
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.IsLoggingEnabled = true;
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(183, 59);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.exitButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.exitButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exitButton.BorderRadius = 1;
            this.exitButton.BorderSize = 0;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.exitButton.IconColor = System.Drawing.Color.Black;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IsLoggingEnabled = true;
            this.exitButton.Location = new System.Drawing.Point(0, 550);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(183, 56);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(183, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(967, 606);
            this.contentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1150, 606);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(1166, 645);
            this.Name = "MainForm";
            this.Text = "ToDo App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private ToDoApp.UI.Controls.RoundButton homeButton;

        private ToDoApp.UI.Controls.RoundButton exitButton;

        private ToDoApp.UI.Controls.RoundButton settingsButton;

        private ToDoApp.UI.Controls.RoundButton tasksButton;

        private System.Windows.Forms.Panel contentPanel;

        private System.Windows.Forms.Panel menuPanel;

        #endregion
    }
}