namespace ToDoApp.UI.Forms
{
    partial class HomeScreen
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
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.greetingsPanel = new System.Windows.Forms.Panel();
            this.upcomingTasksGroupBox = new System.Windows.Forms.GroupBox();
            this.upcomingTasksPanel = new System.Windows.Forms.Panel();
            this.allTasksGroupBox = new System.Windows.Forms.GroupBox();
            this.allTasksPanel = new System.Windows.Forms.Panel();
            this.tasksSplitContainer = new System.Windows.Forms.SplitContainer();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.greetingsPanel.SuspendLayout();
            this.upcomingTasksGroupBox.SuspendLayout();
            this.allTasksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksSplitContainer)).BeginInit();
            this.tasksSplitContainer.Panel1.SuspendLayout();
            this.tasksSplitContainer.Panel2.SuspendLayout();
            this.tasksSplitContainer.SuspendLayout();
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
            this.contentPanel.Controls.Add(this.greetingsPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 47);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(955, 570);
            this.contentPanel.TabIndex = 2;
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
            // greetingsPanel
            // 
            this.greetingsPanel.Controls.Add(this.greetingsLabel);
            this.greetingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.greetingsPanel.Location = new System.Drawing.Point(0, 0);
            this.greetingsPanel.Name = "greetingsPanel";
            this.greetingsPanel.Size = new System.Drawing.Size(955, 55);
            this.greetingsPanel.TabIndex = 4;
            // 
            // upcomingTasksGroupBox
            // 
            this.upcomingTasksGroupBox.Controls.Add(this.upcomingTasksPanel);
            this.upcomingTasksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upcomingTasksGroupBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upcomingTasksGroupBox.Location = new System.Drawing.Point(0, 0);
            this.upcomingTasksGroupBox.Name = "upcomingTasksGroupBox";
            this.upcomingTasksGroupBox.Size = new System.Drawing.Size(470, 515);
            this.upcomingTasksGroupBox.TabIndex = 2;
            this.upcomingTasksGroupBox.TabStop = false;
            this.upcomingTasksGroupBox.Text = "Upcoming tasks";
            // 
            // upcomingTasksPanel
            // 
            this.upcomingTasksPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upcomingTasksPanel.Location = new System.Drawing.Point(3, 22);
            this.upcomingTasksPanel.Name = "upcomingTasksPanel";
            this.upcomingTasksPanel.Size = new System.Drawing.Size(464, 490);
            this.upcomingTasksPanel.TabIndex = 0;
            // 
            // allTasksGroupBox
            // 
            this.allTasksGroupBox.Controls.Add(this.allTasksPanel);
            this.allTasksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allTasksGroupBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allTasksGroupBox.Location = new System.Drawing.Point(0, 0);
            this.allTasksGroupBox.Name = "allTasksGroupBox";
            this.allTasksGroupBox.Size = new System.Drawing.Size(481, 515);
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
            this.allTasksPanel.Size = new System.Drawing.Size(475, 490);
            this.allTasksPanel.TabIndex = 0;
            // 
            // tasksSplitContainer
            // 
            this.tasksSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksSplitContainer.IsSplitterFixed = true;
            this.tasksSplitContainer.Location = new System.Drawing.Point(0, 55);
            this.tasksSplitContainer.Name = "tasksSplitContainer";
            // 
            // tasksSplitContainer.Panel1
            // 
            this.tasksSplitContainer.Panel1.Controls.Add(this.allTasksGroupBox);
            // 
            // tasksSplitContainer.Panel2
            // 
            this.tasksSplitContainer.Panel2.Controls.Add(this.upcomingTasksGroupBox);
            this.tasksSplitContainer.Size = new System.Drawing.Size(955, 515);
            this.tasksSplitContainer.SplitterDistance = 481;
            this.tasksSplitContainer.TabIndex = 1;
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
            this.greetingsPanel.ResumeLayout(false);
            this.greetingsPanel.PerformLayout();
            this.upcomingTasksGroupBox.ResumeLayout(false);
            this.allTasksGroupBox.ResumeLayout(false);
            this.tasksSplitContainer.Panel1.ResumeLayout(false);
            this.tasksSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tasksSplitContainer)).EndInit();
            this.tasksSplitContainer.ResumeLayout(false);
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
    }
}
