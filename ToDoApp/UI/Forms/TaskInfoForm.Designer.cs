namespace ToDoApp.Forms
{
    partial class TaskInfoForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label importanceLabel;
            System.Windows.Forms.Label deadLineLabel;
            System.Windows.Forms.Label creationDateLabel;
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headerLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.importanceLabel1 = new System.Windows.Forms.Label();
            this.deadLineLabel1 = new System.Windows.Forms.Label();
            this.creationDateLabel1 = new System.Windows.Forms.Label();
            this.taskLayout = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            importanceLabel = new System.Windows.Forms.Label();
            deadLineLabel = new System.Windows.Forms.Label();
            creationDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.taskLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(4, 1);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(4, 64);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(95, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // importanceLabel
            // 
            importanceLabel.AutoSize = true;
            importanceLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            importanceLabel.Location = new System.Drawing.Point(4, 335);
            importanceLabel.Name = "importanceLabel";
            importanceLabel.Size = new System.Drawing.Size(100, 20);
            importanceLabel.TabIndex = 4;
            importanceLabel.Text = "Importance:";
            // 
            // deadLineLabel
            // 
            deadLineLabel.AutoSize = true;
            deadLineLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            deadLineLabel.Location = new System.Drawing.Point(4, 398);
            deadLineLabel.Name = "deadLineLabel";
            deadLineLabel.Size = new System.Drawing.Size(87, 20);
            deadLineLabel.TabIndex = 6;
            deadLineLabel.Text = "Dead Line:";
            // 
            // creationDateLabel
            // 
            creationDateLabel.AutoSize = true;
            creationDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            creationDateLabel.Location = new System.Drawing.Point(4, 466);
            creationDateLabel.Name = "creationDateLabel";
            creationDateLabel.Size = new System.Drawing.Size(117, 20);
            creationDateLabel.TabIndex = 8;
            creationDateLabel.Text = "Creation Date:";
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataSource = typeof(Logic.Tasks.Task);
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(612, 86);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Task info";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.headerLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentPanel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(5);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(612, 86);
            this.contentPanel.TabIndex = 4;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Name", true));
            this.nameLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel1.Location = new System.Drawing.Point(177, 1);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(431, 62);
            this.nameLabel1.TabIndex = 1;
            this.nameLabel1.Text = "label1";
            // 
            // importanceLabel1
            // 
            this.importanceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Importance", true));
            this.importanceLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importanceLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importanceLabel1.Location = new System.Drawing.Point(177, 335);
            this.importanceLabel1.Name = "importanceLabel1";
            this.importanceLabel1.Size = new System.Drawing.Size(431, 62);
            this.importanceLabel1.TabIndex = 5;
            this.importanceLabel1.Text = "label1";
            // 
            // deadLineLabel1
            // 
            this.deadLineLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "DeadLine", true));
            this.deadLineLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadLineLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadLineLabel1.Location = new System.Drawing.Point(177, 398);
            this.deadLineLabel1.Name = "deadLineLabel1";
            this.deadLineLabel1.Size = new System.Drawing.Size(431, 67);
            this.deadLineLabel1.TabIndex = 7;
            this.deadLineLabel1.Text = "label1";
            // 
            // creationDateLabel1
            // 
            this.creationDateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "CreationDate", true));
            this.creationDateLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creationDateLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creationDateLabel1.Location = new System.Drawing.Point(177, 466);
            this.creationDateLabel1.Name = "creationDateLabel1";
            this.creationDateLabel1.Size = new System.Drawing.Size(431, 69);
            this.creationDateLabel1.TabIndex = 9;
            this.creationDateLabel1.Text = "label1";
            // 
            // taskLayout
            // 
            this.taskLayout.AutoScroll = true;
            this.taskLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.taskLayout.ColumnCount = 2;
            this.taskLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.30626F));
            this.taskLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.69373F));
            this.taskLayout.Controls.Add(creationDateLabel, 0, 4);
            this.taskLayout.Controls.Add(this.creationDateLabel1, 1, 4);
            this.taskLayout.Controls.Add(deadLineLabel, 0, 3);
            this.taskLayout.Controls.Add(this.deadLineLabel1, 1, 3);
            this.taskLayout.Controls.Add(importanceLabel, 0, 2);
            this.taskLayout.Controls.Add(this.importanceLabel1, 1, 2);
            this.taskLayout.Controls.Add(descriptionLabel, 0, 1);
            this.taskLayout.Controls.Add(nameLabel, 0, 0);
            this.taskLayout.Controls.Add(this.nameLabel1, 1, 0);
            this.taskLayout.Controls.Add(this.descriptionTextBox, 1, 1);
            this.taskLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskLayout.Location = new System.Drawing.Point(0, 86);
            this.taskLayout.Name = "taskLayout";
            this.taskLayout.RowCount = 5;
            this.taskLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.57895F));
            this.taskLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.52632F));
            this.taskLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.57895F));
            this.taskLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.63158F));
            this.taskLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.63158F));
            this.taskLayout.Size = new System.Drawing.Size(612, 536);
            this.taskLayout.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.CausesValidation = false;
            this.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Description", true));
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(177, 67);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionTextBox.ShortcutsEnabled = false;
            this.descriptionTextBox.Size = new System.Drawing.Size(431, 264);
            this.descriptionTextBox.TabIndex = 10;
            this.descriptionTextBox.Text = "";
            this.descriptionTextBox.Enter += new System.EventHandler(this.descriptionTextBox_Enter);
            // 
            // TaskInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(612, 622);
            this.Controls.Add(this.taskLayout);
            this.Controls.Add(this.contentPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(448, 506);
            this.Name = "TaskInfoForm";
            this.Text = "TaskInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.taskLayout.ResumeLayout(false);
            this.taskLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label importanceLabel1;
        private System.Windows.Forms.Label deadLineLabel1;
        private System.Windows.Forms.Label creationDateLabel1;
        private System.Windows.Forms.TableLayoutPanel taskLayout;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
    }
}