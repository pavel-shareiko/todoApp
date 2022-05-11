using Logic.Tasks;

namespace ToDoApp.Forms
{
    partial class NewTaskScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.createButton = new ToDoApp.UI.Controls.RoundButton();
            this.deadLineDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.importanceComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            deadLineLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            importanceLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deadLineLabel
            // 
            deadLineLabel.AutoSize = true;
            deadLineLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            deadLineLabel.Location = new System.Drawing.Point(27, 165);
            deadLineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            deadLineLabel.Name = "deadLineLabel";
            deadLineLabel.Size = new System.Drawing.Size(77, 17);
            deadLineLabel.TabIndex = 0;
            deadLineLabel.Text = "Dead Line:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(27, 52);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(84, 17);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // importanceLabel
            // 
            importanceLabel.AutoSize = true;
            importanceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            importanceLabel.Location = new System.Drawing.Point(27, 131);
            importanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            importanceLabel.Name = "importanceLabel";
            importanceLabel.Size = new System.Drawing.Size(88, 17);
            importanceLabel.TabIndex = 4;
            importanceLabel.Text = "Importance:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(27, 20);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(52, 17);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.headerLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 70);
            this.panel1.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(633, 70);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Create a new task";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.Controls.Add(this.descriptionTextBox);
            this.contentPanel.Controls.Add(this.controlsPanel);
            this.contentPanel.Controls.Add(deadLineLabel);
            this.contentPanel.Controls.Add(this.deadLineDateTimePicker);
            this.contentPanel.Controls.Add(descriptionLabel);
            this.contentPanel.Controls.Add(importanceLabel);
            this.contentPanel.Controls.Add(this.importanceComboBox);
            this.contentPanel.Controls.Add(nameLabel);
            this.contentPanel.Controls.Add(this.nameTextBox);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 70);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(633, 309);
            this.contentPanel.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(150, 52);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(298, 61);
            this.descriptionTextBox.TabIndex = 9;
            this.descriptionTextBox.Text = "";
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(Logic.Tasks.Task);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.createButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsPanel.Location = new System.Drawing.Point(0, 245);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Padding = new System.Windows.Forms.Padding(0, 6, 12, 6);
            this.controlsPanel.Size = new System.Drawing.Size(633, 64);
            this.controlsPanel.TabIndex = 8;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.createButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.createButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createButton.BorderRadius = 40;
            this.createButton.BorderSize = 0;
            this.createButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.createButton.FlatAppearance.BorderSize = 0;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.createButton.IconColor = System.Drawing.Color.White;
            this.createButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createButton.IsLoggingEnabled = true;
            this.createButton.Location = new System.Drawing.Point(474, 6);
            this.createButton.Margin = new System.Windows.Forms.Padding(4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(147, 52);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.TextColor = System.Drawing.Color.White;
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deadLineDateTimePicker
            // 
            this.deadLineDateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadLineDateTimePicker.CustomFormat = "ddddd | dd.MM.yyyy | hh:mm:ss tt";
            this.deadLineDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taskBindingSource, "DeadLine", true));
            this.deadLineDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadLineDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.deadLineDateTimePicker.Location = new System.Drawing.Point(150, 160);
            this.deadLineDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.deadLineDateTimePicker.Name = "deadLineDateTimePicker";
            this.deadLineDateTimePicker.ShowCheckBox = true;
            this.deadLineDateTimePicker.Size = new System.Drawing.Size(298, 21);
            this.deadLineDateTimePicker.TabIndex = 4;
            // 
            // importanceComboBox
            // 
            this.importanceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Importance", true));
            this.importanceComboBox.FormattingEnabled = true;
            this.importanceComboBox.Location = new System.Drawing.Point(150, 127);
            this.importanceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.importanceComboBox.Name = "importanceComboBox";
            this.importanceComboBox.Size = new System.Drawing.Size(298, 24);
            this.importanceComboBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(150, 16);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(298, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 379);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewTaskForm";
            this.Text = "NewTaskForm";
            this.panel1.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.DateTimePicker deadLineDateTimePicker;
        private System.Windows.Forms.ComboBox importanceComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private UI.Controls.RoundButton createButton;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
    }
}