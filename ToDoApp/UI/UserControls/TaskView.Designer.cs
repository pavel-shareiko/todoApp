namespace ToDoApp.UI.Controls
{
    partial class TaskView
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
            this.taskLayout = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.importanceLabel = new System.Windows.Forms.Label();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.taskLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskLayout
            // 
            this.taskLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.taskLayout.ColumnCount = 5;
            this.taskLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.62905F));
            this.taskLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.56449F));
            this.taskLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.17743F));
            this.taskLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.62903F));
            this.taskLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.taskLayout.Controls.Add(this.descriptionLabel, 1, 0);
            this.taskLayout.Controls.Add(this.importanceLabel, 2, 0);
            this.taskLayout.Controls.Add(this.deadlineLabel, 3, 0);
            this.taskLayout.Controls.Add(this.nameLabel, 0, 0);
            this.taskLayout.Controls.Add(this.completedCheckBox, 4, 0);
            this.taskLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskLayout.Location = new System.Drawing.Point(1, 1);
            this.taskLayout.Name = "taskLayout";
            this.taskLayout.RowCount = 1;
            this.taskLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.taskLayout.Size = new System.Drawing.Size(545, 33);
            this.taskLayout.TabIndex = 0;
            this.taskLayout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.taskLayout_MouseClick);
            this.taskLayout.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.taskLayout_MouseDoubleClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoEllipsis = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(118, 1);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(178, 31);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Tag = "Description";
            this.descriptionLabel.Text = "Task description";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // importanceLabel
            // 
            this.importanceLabel.AutoEllipsis = true;
            this.importanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importanceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importanceLabel.Location = new System.Drawing.Point(303, 1);
            this.importanceLabel.Name = "importanceLabel";
            this.importanceLabel.Size = new System.Drawing.Size(61, 31);
            this.importanceLabel.TabIndex = 2;
            this.importanceLabel.Tag = "Importance";
            this.importanceLabel.Text = "Importance";
            this.importanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoEllipsis = true;
            this.deadlineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadlineLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadlineLabel.Location = new System.Drawing.Point(371, 1);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(107, 31);
            this.deadlineLabel.TabIndex = 3;
            this.deadlineLabel.Tag = "Deadline";
            this.deadlineLabel.Text = "Deadline";
            this.deadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(4, 1);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Tag = "Name";
            this.nameLabel.Text = "Task name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // completedCheckBox
            // 
            this.completedCheckBox.AutoSize = true;
            this.completedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.completedCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completedCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completedCheckBox.Location = new System.Drawing.Point(485, 4);
            this.completedCheckBox.Name = "completedCheckBox";
            this.completedCheckBox.Size = new System.Drawing.Size(56, 25);
            this.completedCheckBox.TabIndex = 4;
            this.completedCheckBox.Tag = "Is Completed";
            this.completedCheckBox.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.completedCheckBox.UseVisualStyleBackColor = true;
            this.completedCheckBox.CheckedChanged += new System.EventHandler(this.completedCheckBox_CheckedChanged);
            // 
            // TaskView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.taskLayout);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TaskView";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(547, 35);
            this.taskLayout.ResumeLayout(false);
            this.taskLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel taskLayout;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label importanceLabel;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.CheckBox completedCheckBox;
    }
}
