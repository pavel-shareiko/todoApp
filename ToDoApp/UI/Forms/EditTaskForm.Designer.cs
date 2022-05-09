namespace ToDoApp.Forms
{
    partial class EditTaskForm
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
            System.Windows.Forms.Label deadLineLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label importanceLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label creationDateLabel;
            System.Windows.Forms.Label createDateInfoLabel;
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.saveButton = new ToDoApp.UI.Controls.RoundButton();
            this.deadLineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.importanceComboBox = new System.Windows.Forms.ComboBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            deadLineLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            importanceLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            creationDateLabel = new System.Windows.Forms.Label();
            createDateInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deadLineLabel
            // 
            deadLineLabel.AutoSize = true;
            deadLineLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            deadLineLabel.Location = new System.Drawing.Point(13, 160);
            deadLineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            deadLineLabel.Name = "deadLineLabel";
            deadLineLabel.Size = new System.Drawing.Size(77, 17);
            deadLineLabel.TabIndex = 7;
            deadLineLabel.Text = "Dead Line:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(13, 45);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(84, 17);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Description:";
            // 
            // importanceLabel
            // 
            importanceLabel.AutoSize = true;
            importanceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            importanceLabel.Location = new System.Drawing.Point(13, 126);
            importanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            importanceLabel.Name = "importanceLabel";
            importanceLabel.Size = new System.Drawing.Size(88, 17);
            importanceLabel.TabIndex = 13;
            importanceLabel.Text = "Importance:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(13, 13);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 17);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // creationDateLabel
            // 
            creationDateLabel.AutoSize = true;
            creationDateLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            creationDateLabel.Location = new System.Drawing.Point(13, 191);
            creationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            creationDateLabel.Name = "creationDateLabel";
            creationDateLabel.Size = new System.Drawing.Size(104, 17);
            creationDateLabel.TabIndex = 15;
            creationDateLabel.Text = "Creation date:";
            // 
            // createDateInfoLabel
            // 
            createDateInfoLabel.AutoSize = true;
            createDateInfoLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "CreationDate", true));
            createDateInfoLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            createDateInfoLabel.Location = new System.Drawing.Point(133, 191);
            createDateInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            createDateInfoLabel.Name = "createDateInfoLabel";
            createDateInfoLabel.Size = new System.Drawing.Size(0, 17);
            createDateInfoLabel.TabIndex = 16;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(Logic.Tasks.Task);
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.Controls.Add(this.descriptionTextBox);
            this.contentPanel.Controls.Add(createDateInfoLabel);
            this.contentPanel.Controls.Add(creationDateLabel);
            this.contentPanel.Controls.Add(deadLineLabel);
            this.contentPanel.Controls.Add(this.controlsPanel);
            this.contentPanel.Controls.Add(this.deadLineDateTimePicker);
            this.contentPanel.Controls.Add(descriptionLabel);
            this.contentPanel.Controls.Add(this.nameTextBox);
            this.contentPanel.Controls.Add(nameLabel);
            this.contentPanel.Controls.Add(importanceLabel);
            this.contentPanel.Controls.Add(this.importanceComboBox);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 70);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(654, 380);
            this.contentPanel.TabIndex = 3;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(136, 45);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(298, 61);
            this.descriptionTextBox.TabIndex = 17;
            this.descriptionTextBox.Text = "";
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.saveButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsPanel.Location = new System.Drawing.Point(0, 316);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Padding = new System.Windows.Forms.Padding(0, 6, 12, 6);
            this.controlsPanel.Size = new System.Drawing.Size(654, 64);
            this.controlsPanel.TabIndex = 8;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.saveButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.saveButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveButton.BorderRadius = 40;
            this.saveButton.BorderSize = 0;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.saveButton.IconColor = System.Drawing.Color.White;
            this.saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveButton.IsLoggingEnabled = true;
            this.saveButton.Location = new System.Drawing.Point(495, 6);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(147, 52);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.TextColor = System.Drawing.Color.White;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deadLineDateTimePicker
            // 
            this.deadLineDateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadLineDateTimePicker.CustomFormat = "ddddd | dd.MM.yyyy | hh:mm:ss tt";
            this.deadLineDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taskBindingSource, "DeadLine", true));
            this.deadLineDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadLineDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deadLineDateTimePicker.Location = new System.Drawing.Point(136, 155);
            this.deadLineDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.deadLineDateTimePicker.Name = "deadLineDateTimePicker";
            this.deadLineDateTimePicker.ShowCheckBox = true;
            this.deadLineDateTimePicker.Size = new System.Drawing.Size(298, 21);
            this.deadLineDateTimePicker.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(136, 9);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(298, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // importanceComboBox
            // 
            this.importanceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Importance", true));
            this.importanceComboBox.FormattingEnabled = true;
            this.importanceComboBox.Location = new System.Drawing.Point(136, 122);
            this.importanceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.importanceComboBox.Name = "importanceComboBox";
            this.importanceComboBox.Size = new System.Drawing.Size(298, 21);
            this.importanceComboBox.TabIndex = 11;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(654, 70);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Edit task";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 70);
            this.panel1.TabIndex = 2;
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.Name = "EditTaskForm";
            this.Text = "EditTaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel controlsPanel;
        private UI.Controls.RoundButton saveButton;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.DateTimePicker deadLineDateTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox importanceComboBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
    }
}