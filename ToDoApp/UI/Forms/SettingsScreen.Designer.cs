using System;
using ToDoApp.UI.Themes;

namespace ToDoApp.Forms
{
    partial class SettingsScreen
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.saveButton = new ToDoApp.UI.Controls.RoundButton();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.themeSelector = new System.Windows.Forms.ComboBox();
            this.themeLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(853, 47);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(853, 47);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Settings";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsPanel.Location = new System.Drawing.Point(0, 504);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Padding = new System.Windows.Forms.Padding(0, 5, 15, 5);
            this.controlsPanel.Size = new System.Drawing.Size(853, 51);
            this.controlsPanel.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.saveButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.saveButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveButton.BorderRadius = 40;
            this.saveButton.BorderSize = 0;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.saveButton.IconColor = System.Drawing.Color.White;
            this.saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveButton.IconSize = 20;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.IsLoggingEnabled = true;
            this.saveButton.Location = new System.Drawing.Point(747, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 41);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.TextColor = System.Drawing.Color.White;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.Controls.Add(this.themeSelector);
            this.settingsPanel.Controls.Add(this.themeLabel);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 47);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(853, 457);
            this.settingsPanel.TabIndex = 3;
            // 
            // themeSelector
            // 
            this.themeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeSelector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeSelector.FormattingEnabled = true;
            this.themeSelector.Items.AddRange(new object[] {
            ToDoApp.UI.Themes.Theme.Light,
            ToDoApp.UI.Themes.Theme.Dark,
            ToDoApp.UI.Themes.Theme.Windows});
            this.themeSelector.Location = new System.Drawing.Point(111, 22);
            this.themeSelector.Name = "themeSelector";
            this.themeSelector.Size = new System.Drawing.Size(140, 25);
            this.themeSelector.TabIndex = 1;
            this.themeSelector.SelectionChangeCommitted += new System.EventHandler(this.themeSelector_SelectionChangeCommitted);
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeLabel.Location = new System.Drawing.Point(29, 22);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(63, 21);
            this.themeLabel.TabIndex = 0;
            this.themeLabel.Text = "Theme";
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "SettingsScreen";
            this.Size = new System.Drawing.Size(853, 555);
            this.headerPanel.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private UI.Controls.RoundButton saveButton;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.ComboBox themeSelector;
    }
}
