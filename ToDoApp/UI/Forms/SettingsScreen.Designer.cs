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
            this.notifyBeforeNumUD = new System.Windows.Forms.NumericUpDown();
            this.scanPeriodNumUD = new System.Windows.Forms.NumericUpDown();
            this.pageSizeNumUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.themeSelector = new System.Windows.Forms.ComboBox();
            this.themeLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifyBeforeNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanPeriodNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSizeNumUD)).BeginInit();
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
            this.settingsPanel.Controls.Add(this.notifyBeforeNumUD);
            this.settingsPanel.Controls.Add(this.scanPeriodNumUD);
            this.settingsPanel.Controls.Add(this.pageSizeNumUD);
            this.settingsPanel.Controls.Add(this.label3);
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.themeSelector);
            this.settingsPanel.Controls.Add(this.themeLabel);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 47);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(853, 457);
            this.settingsPanel.TabIndex = 3;
            // 
            // notifyBeforeNumUD
            // 
            this.notifyBeforeNumUD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notifyBeforeNumUD.Location = new System.Drawing.Point(271, 108);
            this.notifyBeforeNumUD.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.notifyBeforeNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.notifyBeforeNumUD.Name = "notifyBeforeNumUD";
            this.notifyBeforeNumUD.Size = new System.Drawing.Size(75, 23);
            this.notifyBeforeNumUD.TabIndex = 7;
            this.notifyBeforeNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.notifyBeforeNumUD.ValueChanged += new System.EventHandler(this.notifyBeforeNumUD_ValueChanged);
            // 
            // scanPeriodNumUD
            // 
            this.scanPeriodNumUD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scanPeriodNumUD.Location = new System.Drawing.Point(271, 79);
            this.scanPeriodNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scanPeriodNumUD.Name = "scanPeriodNumUD";
            this.scanPeriodNumUD.Size = new System.Drawing.Size(75, 23);
            this.scanPeriodNumUD.TabIndex = 6;
            this.scanPeriodNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scanPeriodNumUD.ValueChanged += new System.EventHandler(this.scanPeriodNumUD_ValueChanged);
            // 
            // pageSizeNumUD
            // 
            this.pageSizeNumUD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageSizeNumUD.Location = new System.Drawing.Point(271, 50);
            this.pageSizeNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSizeNumUD.Name = "pageSizeNumUD";
            this.pageSizeNumUD.Size = new System.Drawing.Size(75, 23);
            this.pageSizeNumUD.TabIndex = 5;
            this.pageSizeNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSizeNumUD.ValueChanged += new System.EventHandler(this.pageSizeNumUD_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notify before (minutes):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scan period (seconds):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Page size:";
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
            this.themeSelector.Location = new System.Drawing.Point(271, 19);
            this.themeSelector.Name = "themeSelector";
            this.themeSelector.Size = new System.Drawing.Size(167, 25);
            this.themeSelector.TabIndex = 1;
            this.themeSelector.SelectionChangeCommitted += new System.EventHandler(this.themeSelector_SelectionChangeCommitted);
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themeLabel.Location = new System.Drawing.Point(29, 19);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(67, 21);
            this.themeLabel.TabIndex = 0;
            this.themeLabel.Text = "Theme:";
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
            ((System.ComponentModel.ISupportInitialize)(this.notifyBeforeNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanPeriodNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSizeNumUD)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown notifyBeforeNumUD;
        private System.Windows.Forms.NumericUpDown scanPeriodNumUD;
        private System.Windows.Forms.NumericUpDown pageSizeNumUD;
    }
}
