namespace CustomerApp
{
    partial class MainMenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.addDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.putToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.depositsLabel = new System.Windows.Forms.Label();
            this.depositsGridView = new System.Windows.Forms.DataGridView();
            this.percentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.putButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.myAccountToolStripMenuItem,
            this.depositToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateDataToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logoutToolStripMenuItem});
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.myAccountToolStripMenuItem.Text = "Мой аккаунт";
            // 
            // privateDataToolStripMenuItem
            // 
            this.privateDataToolStripMenuItem.Name = "privateDataToolStripMenuItem";
            this.privateDataToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.privateDataToolStripMenuItem.Text = "Личные данные";
            this.privateDataToolStripMenuItem.Click += new System.EventHandler(this.PrivateDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.logoutToolStripMenuItem.Text = "Выйти из аккаунта";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadAllToolStripMenuItem,
            this.toolStripMenuItem3,
            this.addDepositToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.putToolStripMenuItem});
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.depositToolStripMenuItem.Text = "Депозит";
            // 
            // uploadAllToolStripMenuItem
            // 
            this.uploadAllToolStripMenuItem.Name = "uploadAllToolStripMenuItem";
            this.uploadAllToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.uploadAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uploadAllToolStripMenuItem.Text = "Обновить все";
            this.uploadAllToolStripMenuItem.Click += new System.EventHandler(this.UploadAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // addDepositToolStripMenuItem
            // 
            this.addDepositToolStripMenuItem.Name = "addDepositToolStripMenuItem";
            this.addDepositToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addDepositToolStripMenuItem.Text = "Создать новый";
            this.addDepositToolStripMenuItem.Click += new System.EventHandler(this.AddDepositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.withdrawToolStripMenuItem.Text = "Снять сумму";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.WithdrawToolStripMenuItem_Click);
            // 
            // putToolStripMenuItem
            // 
            this.putToolStripMenuItem.Name = "putToolStripMenuItem";
            this.putToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.putToolStripMenuItem.Text = "Положить сумму";
            this.putToolStripMenuItem.Click += new System.EventHandler(this.PutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(13, 33);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 20);
            this.welcomeLabel.TabIndex = 1;
            // 
            // depositsLabel
            // 
            this.depositsLabel.AutoSize = true;
            this.depositsLabel.Location = new System.Drawing.Point(12, 65);
            this.depositsLabel.Name = "depositsLabel";
            this.depositsLabel.Size = new System.Drawing.Size(105, 16);
            this.depositsLabel.TabIndex = 2;
            this.depositsLabel.Text = "Мои депозиты:";
            // 
            // depositsGridView
            // 
            this.depositsGridView.AllowUserToAddRows = false;
            this.depositsGridView.AllowUserToDeleteRows = false;
            this.depositsGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depositsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.depositsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depositsGridView.AutoGenerateColumns = false;
            this.depositsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.depositsGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.depositsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depositsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.percentColumn,
            this.intervalColumn,
            this.valueColumn,
            this.startDateColumn,
            this.finishDateColumn});
            this.depositsGridView.DataSource = this.depositsBindingSource;
            this.depositsGridView.Location = new System.Drawing.Point(12, 84);
            this.depositsGridView.MultiSelect = false;
            this.depositsGridView.Name = "depositsGridView";
            this.depositsGridView.ReadOnly = true;
            this.depositsGridView.RowHeadersVisible = false;
            this.depositsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.depositsGridView.Size = new System.Drawing.Size(636, 335);
            this.depositsGridView.TabIndex = 6;
            this.depositsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DepositsGridView_CellFormatting);
            this.depositsGridView.SelectionChanged += new System.EventHandler(this.DepositsGridView_SelectionChanged);
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
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 435);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 24);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Создать";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddDepositToolStripMenuItem_Click);
            // 
            // putButton
            // 
            this.putButton.Location = new System.Drawing.Point(111, 435);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(93, 24);
            this.putButton.TabIndex = 8;
            this.putButton.Text = "Положить";
            this.putButton.UseVisualStyleBackColor = true;
            this.putButton.Click += new System.EventHandler(this.PutToolStripMenuItem_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(210, 435);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(93, 24);
            this.withdrawButton.TabIndex = 9;
            this.withdrawButton.Text = "Снять";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.WithdrawToolStripMenuItem_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(660, 471);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.putButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.depositsGridView);
            this.Controls.Add(this.depositsLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(676, 510);
            this.Name = "MainMenuForm";
            this.Text = "Меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depositsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label depositsLabel;
        private System.Windows.Forms.DataGridView depositsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishDateColumn;
        private System.Windows.Forms.BindingSource depositsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem addDepositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem putToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button putButton;
        private System.Windows.Forms.Button withdrawButton;
    }
}