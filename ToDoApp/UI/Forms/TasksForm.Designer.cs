namespace ToDoApp.Forms
{
    partial class TasksForm
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
            this.pagesLabel = new System.Windows.Forms.Label();
            this.nextPageButton = new FontAwesome.Sharp.IconPictureBox();
            this.prevPageButton = new FontAwesome.Sharp.IconPictureBox();
            this.dataViewPanel = new System.Windows.Forms.Panel();
            this.detailsButton = new ToDoApp.UI.Controls.RoundButton();
            this.editButton = new ToDoApp.UI.Controls.RoundButton();
            this.deleteButton = new ToDoApp.UI.Controls.RoundButton();
            this.newButton = new ToDoApp.UI.Controls.RoundButton();
            this.headerPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(995, 58);
            this.headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(995, 58);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Your Tasks";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.pagesLabel);
            this.controlsPanel.Controls.Add(this.detailsButton);
            this.controlsPanel.Controls.Add(this.nextPageButton);
            this.controlsPanel.Controls.Add(this.prevPageButton);
            this.controlsPanel.Controls.Add(this.editButton);
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.newButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlsPanel.Location = new System.Drawing.Point(0, 58);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Padding = new System.Windows.Forms.Padding(0, 15, 18, 15);
            this.controlsPanel.Size = new System.Drawing.Size(995, 63);
            this.controlsPanel.TabIndex = 1;
            // 
            // pagesLabel
            // 
            this.pagesLabel.AutoSize = true;
            this.pagesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pagesLabel.Location = new System.Drawing.Point(173, 18);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(149, 21);
            this.pagesLabel.TabIndex = 6;
            this.pagesLabel.Text = "Page {p} of {max}";
            this.pagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextPageButton
            // 
            this.nextPageButton.BackColor = System.Drawing.SystemColors.Control;
            this.nextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPageButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.nextPageButton.IconColor = System.Drawing.Color.White;
            this.nextPageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nextPageButton.IconSize = 28;
            this.nextPageButton.Location = new System.Drawing.Point(117, 18);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(28, 32);
            this.nextPageButton.TabIndex = 4;
            this.nextPageButton.TabStop = false;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // prevPageButton
            // 
            this.prevPageButton.BackColor = System.Drawing.SystemColors.Control;
            this.prevPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevPageButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.prevPageButton.IconColor = System.Drawing.Color.White;
            this.prevPageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.prevPageButton.IconSize = 28;
            this.prevPageButton.Location = new System.Drawing.Point(83, 18);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(28, 32);
            this.prevPageButton.TabIndex = 3;
            this.prevPageButton.TabStop = false;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // dataViewPanel
            // 
            this.dataViewPanel.AutoScroll = true;
            this.dataViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewPanel.Location = new System.Drawing.Point(0, 121);
            this.dataViewPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dataViewPanel.Name = "dataViewPanel";
            this.dataViewPanel.Padding = new System.Windows.Forms.Padding(8);
            this.dataViewPanel.Size = new System.Drawing.Size(995, 492);
            this.dataViewPanel.TabIndex = 2;
            // 
            // detailsButton
            // 
            this.detailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.detailsButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.detailsButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.detailsButton.BorderRadius = 40;
            this.detailsButton.BorderSize = 0;
            this.detailsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.detailsButton.FlatAppearance.BorderSize = 0;
            this.detailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailsButton.ForeColor = System.Drawing.Color.White;
            this.detailsButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.detailsButton.IconColor = System.Drawing.Color.White;
            this.detailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detailsButton.IsLoggingEnabled = true;
            this.detailsButton.Location = new System.Drawing.Point(709, 15);
            this.detailsButton.Margin = new System.Windows.Forms.Padding(4);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(67, 33);
            this.detailsButton.TabIndex = 5;
            this.detailsButton.Text = "Details";
            this.detailsButton.TextColor = System.Drawing.Color.White;
            this.detailsButton.UseVisualStyleBackColor = false;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.editButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.editButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editButton.BorderRadius = 40;
            this.editButton.BorderSize = 0;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.editButton.IconColor = System.Drawing.Color.White;
            this.editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editButton.IsLoggingEnabled = true;
            this.editButton.Location = new System.Drawing.Point(776, 15);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(67, 33);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.TextColor = System.Drawing.Color.White;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.deleteButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.deleteButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButton.BorderRadius = 40;
            this.deleteButton.BorderSize = 0;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.deleteButton.IconColor = System.Drawing.Color.White;
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteButton.IsLoggingEnabled = true;
            this.deleteButton.Location = new System.Drawing.Point(843, 15);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(67, 33);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.TextColor = System.Drawing.Color.White;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.newButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.newButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.newButton.BorderRadius = 40;
            this.newButton.BorderSize = 0;
            this.newButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.newButton.FlatAppearance.BorderSize = 0;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.newButton.IconColor = System.Drawing.Color.White;
            this.newButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.newButton.IsLoggingEnabled = true;
            this.newButton.Location = new System.Drawing.Point(910, 15);
            this.newButton.Margin = new System.Windows.Forms.Padding(4);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(67, 33);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.TextColor = System.Drawing.Color.White;
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // TasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataViewPanel);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TasksForm";
            this.Size = new System.Drawing.Size(995, 613);
            this.headerPanel.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPageButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel dataViewPanel;
        private System.Windows.Forms.Label headerLabel;
        private UI.Controls.RoundButton newButton;
        private UI.Controls.RoundButton editButton;
        private UI.Controls.RoundButton deleteButton;
        private FontAwesome.Sharp.IconPictureBox nextPageButton;
        private FontAwesome.Sharp.IconPictureBox prevPageButton;
        private UI.Controls.RoundButton detailsButton;
        private System.Windows.Forms.Label pagesLabel;
    }
}
