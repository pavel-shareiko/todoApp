namespace ToDoApp.Forms
{
    partial class TasksUserControl
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
            this.components = new System.ComponentModel.Container();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.filterButton = new ToDoApp.UI.Controls.RoundButton();
            this.filterCms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completionStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadButton = new ToDoApp.UI.Controls.RoundButton();
            this.paginationPanel = new System.Windows.Forms.Panel();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.nextPageButton = new FontAwesome.Sharp.IconPictureBox();
            this.prevPageButton = new FontAwesome.Sharp.IconPictureBox();
            this.detailsButton = new ToDoApp.UI.Controls.RoundButton();
            this.editButton = new ToDoApp.UI.Controls.RoundButton();
            this.deleteButton = new ToDoApp.UI.Controls.RoundButton();
            this.newButton = new ToDoApp.UI.Controls.RoundButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.dataGridViewPanel = new System.Windows.Forms.Panel();
            this.tasksDataGridViewPanel = new System.Windows.Forms.Panel();
            this.tableHeadersPanel = new System.Windows.Forms.Panel();
            this.taskLayoutHeaders = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.importanceLabel = new System.Windows.Forms.Label();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.completedLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.controlsPanel.SuspendLayout();
            this.filterCms.SuspendLayout();
            this.paginationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPageButton)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.dataGridViewPanel.SuspendLayout();
            this.tableHeadersPanel.SuspendLayout();
            this.taskLayoutHeaders.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.filterButton);
            this.controlsPanel.Controls.Add(this.reloadButton);
            this.controlsPanel.Controls.Add(this.paginationPanel);
            this.controlsPanel.Controls.Add(this.detailsButton);
            this.controlsPanel.Controls.Add(this.editButton);
            this.controlsPanel.Controls.Add(this.deleteButton);
            this.controlsPanel.Controls.Add(this.newButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlsPanel.Location = new System.Drawing.Point(0, 47);
            this.controlsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Padding = new System.Windows.Forms.Padding(0, 12, 18, 12);
            this.controlsPanel.Size = new System.Drawing.Size(1402, 63);
            this.controlsPanel.TabIndex = 1;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.filterButton.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.filterButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.filterButton.BorderRadius = 40;
            this.filterButton.BorderSize = 0;
            this.filterButton.ContextMenuStrip = this.filterCms;
            this.filterButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterButton.FlatAppearance.BorderSize = 0;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterButton.ForeColor = System.Drawing.Color.White;
            this.filterButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.filterButton.IconColor = System.Drawing.Color.White;
            this.filterButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterButton.IconSize = 22;
            this.filterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterButton.IsLoggingEnabled = true;
            this.filterButton.Location = new System.Drawing.Point(670, 12);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.filterButton.Size = new System.Drawing.Size(119, 39);
            this.filterButton.TabIndex = 9;
            this.filterButton.Text = "Filter";
            this.filterButton.TextColor = System.Drawing.Color.White;
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterCms
            // 
            this.filterCms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.currentFilterToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.importanceToolStripMenuItem,
            this.completionStatusToolStripMenuItem,
            this.deadLineToolStripMenuItem});
            this.filterCms.Name = "filterCms";
            this.filterCms.Size = new System.Drawing.Size(173, 136);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.resetToolStripMenuItem.Text = "(Reset)";
            // 
            // currentFilterToolStripMenuItem
            // 
            this.currentFilterToolStripMenuItem.Name = "currentFilterToolStripMenuItem";
            this.currentFilterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.currentFilterToolStripMenuItem.Text = "(Current Filter)";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.filterToolStripMenuItem.Text = "(Apply Filter)";
            // 
            // importanceToolStripMenuItem
            // 
            this.importanceToolStripMenuItem.Name = "importanceToolStripMenuItem";
            this.importanceToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.importanceToolStripMenuItem.Text = "Importance";
            // 
            // completionStatusToolStripMenuItem
            // 
            this.completionStatusToolStripMenuItem.Name = "completionStatusToolStripMenuItem";
            this.completionStatusToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.completionStatusToolStripMenuItem.Text = "Completion Status";
            // 
            // deadLineToolStripMenuItem
            // 
            this.deadLineToolStripMenuItem.Name = "deadLineToolStripMenuItem";
            this.deadLineToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deadLineToolStripMenuItem.Text = "DeadLine";
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
            this.reloadButton.Location = new System.Drawing.Point(789, 12);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.reloadButton.Size = new System.Drawing.Size(119, 39);
            this.reloadButton.TabIndex = 8;
            this.reloadButton.Text = "Reload";
            this.reloadButton.TextColor = System.Drawing.Color.White;
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // paginationPanel
            // 
            this.paginationPanel.Controls.Add(this.pagesLabel);
            this.paginationPanel.Controls.Add(this.nextPageButton);
            this.paginationPanel.Controls.Add(this.prevPageButton);
            this.paginationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.paginationPanel.Location = new System.Drawing.Point(0, 12);
            this.paginationPanel.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.paginationPanel.Name = "paginationPanel";
            this.paginationPanel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.paginationPanel.Size = new System.Drawing.Size(267, 39);
            this.paginationPanel.TabIndex = 7;
            // 
            // pagesLabel
            // 
            this.pagesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pagesLabel.Location = new System.Drawing.Point(77, 0);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(180, 21);
            this.pagesLabel.TabIndex = 6;
            this.pagesLabel.Text = "Page 0 of 0";
            this.pagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextPageButton
            // 
            this.nextPageButton.BackColor = System.Drawing.SystemColors.Control;
            this.nextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextPageButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.nextPageButton.IconColor = System.Drawing.Color.White;
            this.nextPageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nextPageButton.IconSize = 28;
            this.nextPageButton.Location = new System.Drawing.Point(43, 0);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(28, 39);
            this.nextPageButton.TabIndex = 4;
            this.nextPageButton.TabStop = false;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // prevPageButton
            // 
            this.prevPageButton.BackColor = System.Drawing.SystemColors.Control;
            this.prevPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevPageButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.prevPageButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.prevPageButton.IconColor = System.Drawing.Color.White;
            this.prevPageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.prevPageButton.IconSize = 28;
            this.prevPageButton.Location = new System.Drawing.Point(15, 0);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(28, 39);
            this.prevPageButton.TabIndex = 3;
            this.prevPageButton.TabStop = false;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
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
            this.detailsButton.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.detailsButton.IconColor = System.Drawing.Color.White;
            this.detailsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.detailsButton.IconSize = 22;
            this.detailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detailsButton.IsLoggingEnabled = true;
            this.detailsButton.Location = new System.Drawing.Point(908, 12);
            this.detailsButton.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.detailsButton.Size = new System.Drawing.Size(119, 39);
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
            this.editButton.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.editButton.IconColor = System.Drawing.Color.White;
            this.editButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editButton.IconSize = 22;
            this.editButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editButton.IsLoggingEnabled = true;
            this.editButton.Location = new System.Drawing.Point(1027, 12);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.editButton.Name = "editButton";
            this.editButton.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.editButton.Size = new System.Drawing.Size(119, 39);
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
            this.deleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deleteButton.IconColor = System.Drawing.Color.White;
            this.deleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteButton.IconSize = 22;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.IsLoggingEnabled = true;
            this.deleteButton.Location = new System.Drawing.Point(1146, 12);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.deleteButton.Size = new System.Drawing.Size(119, 39);
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
            this.newButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.newButton.IconColor = System.Drawing.Color.White;
            this.newButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.newButton.IconSize = 25;
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newButton.IsLoggingEnabled = true;
            this.newButton.Location = new System.Drawing.Point(1265, 12);
            this.newButton.Margin = new System.Windows.Forms.Padding(4, 4, 9, 4);
            this.newButton.Name = "newButton";
            this.newButton.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.newButton.Size = new System.Drawing.Size(119, 39);
            this.newButton.TabIndex = 0;
            this.newButton.Text = "New";
            this.newButton.TextColor = System.Drawing.Color.White;
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.Controls.Add(this.dataGridViewPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 110);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(8);
            this.contentPanel.Size = new System.Drawing.Size(1402, 648);
            this.contentPanel.TabIndex = 2;
            // 
            // dataGridViewPanel
            // 
            this.dataGridViewPanel.Controls.Add(this.tasksDataGridViewPanel);
            this.dataGridViewPanel.Controls.Add(this.tableHeadersPanel);
            this.dataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPanel.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewPanel.Name = "dataGridViewPanel";
            this.dataGridViewPanel.Size = new System.Drawing.Size(1386, 632);
            this.dataGridViewPanel.TabIndex = 0;
            // 
            // tasksDataGridViewPanel
            // 
            this.tasksDataGridViewPanel.AutoScroll = true;
            this.tasksDataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksDataGridViewPanel.Location = new System.Drawing.Point(0, 47);
            this.tasksDataGridViewPanel.Name = "tasksDataGridViewPanel";
            this.tasksDataGridViewPanel.Size = new System.Drawing.Size(1386, 585);
            this.tasksDataGridViewPanel.TabIndex = 1;
            // 
            // tableHeadersPanel
            // 
            this.tableHeadersPanel.Controls.Add(this.taskLayoutHeaders);
            this.tableHeadersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableHeadersPanel.Location = new System.Drawing.Point(0, 0);
            this.tableHeadersPanel.Name = "tableHeadersPanel";
            this.tableHeadersPanel.Size = new System.Drawing.Size(1386, 47);
            this.tableHeadersPanel.TabIndex = 0;
            // 
            // taskLayoutHeaders
            // 
            this.taskLayoutHeaders.ColumnCount = 5;
            this.taskLayoutHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.62905F));
            this.taskLayoutHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.56449F));
            this.taskLayoutHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.17743F));
            this.taskLayoutHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.62903F));
            this.taskLayoutHeaders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.taskLayoutHeaders.Controls.Add(this.descriptionLabel, 1, 0);
            this.taskLayoutHeaders.Controls.Add(this.importanceLabel, 2, 0);
            this.taskLayoutHeaders.Controls.Add(this.deadlineLabel, 3, 0);
            this.taskLayoutHeaders.Controls.Add(this.nameLabel, 0, 0);
            this.taskLayoutHeaders.Controls.Add(this.completedLabel, 4, 0);
            this.taskLayoutHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskLayoutHeaders.Location = new System.Drawing.Point(0, 0);
            this.taskLayoutHeaders.Name = "taskLayoutHeaders";
            this.taskLayoutHeaders.RowCount = 1;
            this.taskLayoutHeaders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.taskLayoutHeaders.Size = new System.Drawing.Size(1386, 47);
            this.taskLayoutHeaders.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoEllipsis = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(310, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(495, 47);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Tag = "Description";
            this.descriptionLabel.Text = "Task description";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // importanceLabel
            // 
            this.importanceLabel.AutoEllipsis = true;
            this.importanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importanceLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importanceLabel.Location = new System.Drawing.Point(811, 0);
            this.importanceLabel.Name = "importanceLabel";
            this.importanceLabel.Size = new System.Drawing.Size(178, 47);
            this.importanceLabel.TabIndex = 2;
            this.importanceLabel.Tag = "Importance";
            this.importanceLabel.Text = "Importance";
            this.importanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoEllipsis = true;
            this.deadlineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deadlineLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deadlineLabel.Location = new System.Drawing.Point(995, 0);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(301, 47);
            this.deadlineLabel.TabIndex = 3;
            this.deadlineLabel.Tag = "Deadline";
            this.deadlineLabel.Text = "Deadline";
            this.deadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(301, 47);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Tag = "Name";
            this.nameLabel.Text = "Task name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completedLabel
            // 
            this.completedLabel.AutoSize = true;
            this.completedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completedLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completedLabel.Location = new System.Drawing.Point(1302, 0);
            this.completedLabel.Name = "completedLabel";
            this.completedLabel.Size = new System.Drawing.Size(81, 47);
            this.completedLabel.TabIndex = 4;
            this.completedLabel.Text = "Completed";
            this.completedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1402, 47);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Your Tasks";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1402, 47);
            this.headerPanel.TabIndex = 0;
            // 
            // TasksScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TasksScreen";
            this.Size = new System.Drawing.Size(1402, 758);
            this.controlsPanel.ResumeLayout(false);
            this.filterCms.ResumeLayout(false);
            this.paginationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prevPageButton)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.dataGridViewPanel.ResumeLayout(false);
            this.tableHeadersPanel.ResumeLayout(false);
            this.taskLayoutHeaders.ResumeLayout(false);
            this.taskLayoutHeaders.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel contentPanel;
        private UI.Controls.RoundButton newButton;
        private UI.Controls.RoundButton editButton;
        private UI.Controls.RoundButton deleteButton;
        private FontAwesome.Sharp.IconPictureBox nextPageButton;
        private FontAwesome.Sharp.IconPictureBox prevPageButton;
        private UI.Controls.RoundButton detailsButton;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.Panel paginationPanel;
        private UI.Controls.RoundButton reloadButton;
        private System.Windows.Forms.Panel dataGridViewPanel;
        private System.Windows.Forms.Panel tasksDataGridViewPanel;
        private System.Windows.Forms.Panel tableHeadersPanel;
        private System.Windows.Forms.TableLayoutPanel taskLayoutHeaders;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label importanceLabel;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label completedLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel headerPanel;
        private UI.Controls.RoundButton filterButton;
        private System.Windows.Forms.ContextMenuStrip filterCms;
        private System.Windows.Forms.ToolStripMenuItem importanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completionStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentFilterToolStripMenuItem;
    }
}
