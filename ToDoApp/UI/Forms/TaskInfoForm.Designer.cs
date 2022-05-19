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
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.headerLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.headerLabel.Size = new System.Drawing.Size(434, 86);
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
            this.contentPanel.Size = new System.Drawing.Size(434, 86);
            this.contentPanel.TabIndex = 4;
            // 
            // infoPanel
            // 
            this.infoPanel.AutoScroll = true;
            this.infoPanel.AutoSize = true;
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPanel.Location = new System.Drawing.Point(0, 86);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(434, 0);
            this.infoPanel.TabIndex = 5;
            // 
            // TaskInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.contentPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(450, 39);
            this.Name = "TaskInfoForm";
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel infoPanel;
    }
}