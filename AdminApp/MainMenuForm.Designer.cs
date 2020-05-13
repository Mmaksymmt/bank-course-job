namespace AdminApp
{
    partial class MainMenuForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.депозитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepositsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersListLabel = new System.Windows.Forms.Label();
            this.depositsListLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.loginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositsGridView = new System.Windows.Forms.DataGridView();
            this.percentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.клиентToolStripMenuItem,
            this.депозитToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerInfoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.deleteToolStripMenuItem});
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.клиентToolStripMenuItem.Text = "Клиент";
            // 
            // customerInfoToolStripMenuItem
            // 
            this.customerInfoToolStripMenuItem.Name = "customerInfoToolStripMenuItem";
            this.customerInfoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.customerInfoToolStripMenuItem.Text = "Информация";
            this.customerInfoToolStripMenuItem.Click += new System.EventHandler(this.CustomerInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // депозитToolStripMenuItem
            // 
            this.депозитToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadAllToolStripMenuItem,
            this.editDepositToolStripMenuItem,
            this.toolStripMenuItem2,
            this.deleteDepositToolStripMenuItem});
            this.депозитToolStripMenuItem.Name = "депозитToolStripMenuItem";
            this.депозитToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.депозитToolStripMenuItem.Text = "Депозит";
            // 
            // uploadAllToolStripMenuItem
            // 
            this.uploadAllToolStripMenuItem.Name = "uploadAllToolStripMenuItem";
            this.uploadAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.uploadAllToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.uploadAllToolStripMenuItem.Text = "Обновить все";
            this.uploadAllToolStripMenuItem.Click += new System.EventHandler(this.UploadAllToolStripMenuItem_Click);
            // 
            // editDepositToolStripMenuItem
            // 
            this.editDepositToolStripMenuItem.Name = "editDepositToolStripMenuItem";
            this.editDepositToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editDepositToolStripMenuItem.Text = "Редактировать";
            this.editDepositToolStripMenuItem.Click += new System.EventHandler(this.EditDepositToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 6);
            // 
            // deleteDepositToolStripMenuItem
            // 
            this.deleteDepositToolStripMenuItem.Name = "deleteDepositToolStripMenuItem";
            this.deleteDepositToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deleteDepositToolStripMenuItem.Text = "Удалить";
            this.deleteDepositToolStripMenuItem.Click += new System.EventHandler(this.DeleteDepositToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // usersListLabel
            // 
            this.usersListLabel.AutoSize = true;
            this.usersListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersListLabel.Location = new System.Drawing.Point(3, 13);
            this.usersListLabel.Name = "usersListLabel";
            this.usersListLabel.Size = new System.Drawing.Size(71, 16);
            this.usersListLabel.TabIndex = 3;
            this.usersListLabel.Text = "Клиенты";
            // 
            // depositsListLabel
            // 
            this.depositsListLabel.AutoSize = true;
            this.depositsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depositsListLabel.Location = new System.Drawing.Point(3, 13);
            this.depositsListLabel.Name = "depositsListLabel";
            this.depositsListLabel.Size = new System.Drawing.Size(81, 16);
            this.depositsListLabel.TabIndex = 4;
            this.depositsListLabel.Text = "Депозиты";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.usersGridView);
            this.splitContainer1.Panel1.Controls.Add(this.usersListLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.depositsGridView);
            this.splitContainer1.Panel2.Controls.Add(this.depositsListLabel);
            this.splitContainer1.Size = new System.Drawing.Size(884, 537);
            this.splitContainer1.SplitterDistance = 359;
            this.splitContainer1.TabIndex = 5;
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersGridView.AutoGenerateColumns = false;
            this.usersGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.usersGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginColumn,
            this.fullNameColumn});
            this.usersGridView.DataSource = this.CustomersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.usersGridView.Location = new System.Drawing.Point(3, 37);
            this.usersGridView.MultiSelect = false;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(353, 497);
            this.usersGridView.TabIndex = 4;
            this.usersGridView.SelectionChanged += new System.EventHandler(this.UsersGridView_SelectedValueChanged);
            // 
            // loginColumn
            // 
            this.loginColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.loginColumn.DataPropertyName = "Login";
            this.loginColumn.HeaderText = "Логин";
            this.loginColumn.Name = "loginColumn";
            this.loginColumn.ReadOnly = true;
            // 
            // fullNameColumn
            // 
            this.fullNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameColumn.DataPropertyName = "FullName";
            this.fullNameColumn.HeaderText = "Ф.И.О";
            this.fullNameColumn.Name = "fullNameColumn";
            this.fullNameColumn.ReadOnly = true;
            // 
            // depositsGridView
            // 
            this.depositsGridView.AllowUserToAddRows = false;
            this.depositsGridView.AllowUserToDeleteRows = false;
            this.depositsGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depositsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.depositsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depositsGridView.AutoGenerateColumns = false;
            this.depositsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.depositsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.depositsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.depositsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depositsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.percentColumn,
            this.intervalColumn,
            this.valueColumn,
            this.startDateColumn,
            this.finishDateColumn});
            this.depositsGridView.DataSource = this.DepositsBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.depositsGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.depositsGridView.Location = new System.Drawing.Point(3, 37);
            this.depositsGridView.MultiSelect = false;
            this.depositsGridView.Name = "depositsGridView";
            this.depositsGridView.ReadOnly = true;
            this.depositsGridView.RowHeadersVisible = false;
            this.depositsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.depositsGridView.Size = new System.Drawing.Size(515, 497);
            this.depositsGridView.TabIndex = 5;
            this.depositsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.depositsGridView_CellFormatting);
            // 
            // percentColumn
            // 
            this.percentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.percentColumn.DataPropertyName = "Percent";
            this.percentColumn.HeaderText = "%";
            this.percentColumn.MinimumWidth = 30;
            this.percentColumn.Name = "percentColumn";
            this.percentColumn.ReadOnly = true;
            this.percentColumn.Width = 30;
            // 
            // intervalColumn
            // 
            this.intervalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.intervalColumn.DataPropertyName = "Interval";
            this.intervalColumn.HeaderText = "";
            this.intervalColumn.Name = "intervalColumn";
            this.intervalColumn.ReadOnly = true;
            this.intervalColumn.Width = 19;
            // 
            // valueColumn
            // 
            this.valueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueColumn.DataPropertyName = "Value";
            this.valueColumn.HeaderText = "Сумма";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.ReadOnly = true;
            // 
            // startDateColumn
            // 
            this.startDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateColumn.DataPropertyName = "StartDate";
            this.startDateColumn.FillWeight = 70F;
            this.startDateColumn.HeaderText = "Начало";
            this.startDateColumn.Name = "startDateColumn";
            this.startDateColumn.ReadOnly = true;
            // 
            // finishDateColumn
            // 
            this.finishDateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.finishDateColumn.DataPropertyName = "FinishDate";
            this.finishDateColumn.FillWeight = 70F;
            this.finishDateColumn.HeaderText = "Конец";
            this.finishDateColumn.Name = "finishDateColumn";
            this.finishDateColumn.ReadOnly = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainMenuForm";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositsBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private System.Windows.Forms.Label usersListLabel;
        private System.Windows.Forms.Label depositsListLabel;
        private System.Windows.Forms.BindingSource DepositsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem депозитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDepositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem customerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem editDepositToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.DataGridView depositsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDateColumn;
    }
}

