namespace ToDoApp.UI.Forms
{
    partial class HomeUserControl
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.tasksSplitContainer = new System.Windows.Forms.SplitContainer();
            this.allTasksGroupBox = new System.Windows.Forms.GroupBox();
            this.allTasksPanel = new System.Windows.Forms.Panel();
            this.upcomingTasksGroupBox = new System.Windows.Forms.GroupBox();
            this.upcomingTasksPanel = new System.Windows.Forms.Panel();
            this.greetingsPanel = new System.Windows.Forms.Panel();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.reloadButton = new ToDoApp.UI.Controls.RoundButton();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksSplitContainer)).BeginInit();
            this.tasksSplitContainer.Panel1.SuspendLayout();
            this.tasksSplitContainer.Panel2.SuspendLayout();
            this.tasksSplitContainer.SuspendLayout();
            this.allTasksGroupBox.SuspendLayout();
            this.upcomingTasksGroupBox.SuspendLayout();
            this.greetingsPanel.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(955, 47);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Home";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(955, 47);
            this.headerPanel.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.tasksSplitContainer);
            this.contentPanel.Controls.Add(this.controlsPanel);
            this.contentPanel.Controls.Add(this.greetingsPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 47);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(955, 570);
            this.contentPanel.TabIndex = 2;
            // 
            // tasksSplitContainer
            // 
            this.tasksSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksSplitContainer.IsSplitterFixed = true;
            this.tasksSplitContainer.Location = new System.Drawing.Point(0, 103);
            this.tasksSplitContainer.Name = "tasksSplitContainer";
            // 
            // tasksSplitContainer.Panel1
            // 
            this.tasksSplitContainer.Panel1.Controls.Add(this.allTasksGroupBox);
            // 
            // tasksSplitContainer.Panel2
            // 
            this.tasksSplitContainer.Panel2.Controls.Add(this.upcomingTasksGroupBox);
            this.tasksSplitContainer.Size = new System.Drawing.Size(955, 467);
            this.tasksSplitContainer.SplitterDistance = 481;
            this.tasksSplitContainer.TabIndex = 1;
            // 
            // allTasksGroupBox
            // 
            this.allTasksGroupBox.Controls.Add(this.allTasksPanel);
            this.allTasksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allTasksGroupBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allTasksGroupBox.Location = new System.Drawing.Point(0, 0);
            this.allTasksGroupBox.Name = "allTasksGroupBox";
            this.allTasksGroupBox.Size = new System.Drawing.Size(481, 467);
            this.allTasksGroupBox.TabIndex = 1;
            this.allTasksGroupBox.TabStop = false;
            this.allTasksGroupBox.Text = "Your tasks";
            // 
            // allTasksPanel
            // 
            this.allTasksPanel.AutoScroll = true;
            this.allTasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allTasksPanel.Location = new System.Drawing.Point(3, 22);
            this.allTasksPanel.Name = "allTasksPanel";
            this.allTasksPanel.Size = new System.Drawing.Size(475, 442);
            this.allTasksPanel.TabIndex = 0;
            // 
            // upcomingTasksGroupBox
            // 
            this.upcomingTasksGroupBox.Controls.Add(this.upcomingTasksPanel);
            this.upcomingTasksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upcomingTasksGroupBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upcomingTasksGroupBox.Location = new System.Drawing.Point(0, 0);
            this.upcomingTasksGroupBox.Name = "upcomingTasksGroupBox";
            this.upcomingTasksGroupBox.Size = new System.Drawing.Size(470, 467);
            this.upcomingTasksGroupBox.TabIndex = 2;
            this.upcomingTasksGroupBox.TabStop = false;
            this.upcomingTasksGroupBox.Text = "Upcoming tasks";
            // 
            // upcomingTasksPanel
            // 
            this.upcomingTasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upcomingTasksPanel.Location = new System.Drawing.Point(3, 22);
            this.upcomingTasksPanel.Name = "upcomingTasksPanel";
            this.upcomingTasksPanel.Size = new System.Drawing.Size(464, 442);
            this.upcomingTasksPanel.TabIndex = 0;
            // 
            // greetingsPanel
            // 
            this.greetingsPanel.Controls.Add(this.greetingsLabel);
            this.greetingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.greetingsPanel.Location = new System.Drawing.Point(0, 0);
            this.greetingsPanel.Name = "greetingsPanel";
            this.greetingsPanel.Size = new System.Drawing.Size(955, 55);
            this.greetingsPanel.TabIndex = 4;
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.greetingsLabel.AutoSize = true;
            this.greetingsLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetingsLabel.Location = new System.Drawing.Point(0, 16);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.greetingsLabel.Size = new System.Drawing.Size(309, 21);
            this.greetingsLabel.TabIndex = 0;
            this.greetingsLabel.Text = "Hi, {name}! You have {n} tasks to do!";
            this.greetingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.reloadButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlsPanel.Location = new System.Drawing.Point(0, 55);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.controlsPanel.Size = new System.Drawing.Size(955, 48);
            this.controlsPanel.TabIndex = 1;
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.reloadButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.reloadButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.reloadButton.BorderRadius = 40;
            this.reloadButton.BorderSize = 0;
            this.reloadButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.reloadButton.FlatAppearance.BorderSize = 0;
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadButton.ForeColor = System.Drawing.Color.White;
            this.reloadButton.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.reloadButton.IconColor = System.Drawing.Color.White;
            this.reloadButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reloadButton.IconSize = 22;
            this.reloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reloadButton.IsLoggingEnabled = true;
            this.reloadButton.Location = new System.Drawing.Point(831, 5);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.reloadButton.Size = new System.Drawing.Size(119, 38);
            this.reloadButton.TabIndex = 9;
            this.reloadButton.Text = "Reload";
            this.reloadButton.TextColor = System.Drawing.Color.White;
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(955, 617);
            this.headerPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.tasksSplitContainer.Panel1.ResumeLayout(false);
            this.tasksSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksSplitContainer)).EndInit();
            this.tasksSplitContainer.ResumeLayout(false);
            this.allTasksGroupBox.ResumeLayout(false);
            this.upcomingTasksGroupBox.ResumeLayout(false);
            this.greetingsPanel.ResumeLayout(false);
            this.greetingsPanel.PerformLayout();
            this.controlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label greetingsLabel;
        private System.Windows.Forms.Panel greetingsPanel;
        private System.Windows.Forms.SplitContainer tasksSplitContainer;
        private System.Windows.Forms.GroupBox allTasksGroupBox;
        private System.Windows.Forms.Panel allTasksPanel;
        private System.Windows.Forms.GroupBox upcomingTasksGroupBox;
        private System.Windows.Forms.Panel upcomingTasksPanel;
        private System.Windows.Forms.Panel controlsPanel;
        private Controls.RoundButton reloadButton;
    }
}
