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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.депозитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersList = new System.Windows.Forms.ListBox();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepositsList = new System.Windows.Forms.ListBox();
            this.DepositsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersListLabel = new System.Windows.Forms.Label();
            this.DepositsListLabel = new System.Windows.Forms.Label();
            this.UploadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositsBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.LoadToolStripMenuItem.Text = "Загрузить";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.клиентToolStripMenuItem.Text = "Клиент";
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // депозитToolStripMenuItem
            // 
            this.депозитToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UploadAllToolStripMenuItem,
            this.toolStripMenuItem2,
            this.DeleteDepositToolStripMenuItem});
            this.депозитToolStripMenuItem.Name = "депозитToolStripMenuItem";
            this.депозитToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.депозитToolStripMenuItem.Text = "Депозит";
            // 
            // DeleteDepositToolStripMenuItem
            // 
            this.DeleteDepositToolStripMenuItem.Name = "DeleteDepositToolStripMenuItem";
            this.DeleteDepositToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteDepositToolStripMenuItem.Text = "Удалить";
            this.DeleteDepositToolStripMenuItem.Click += new System.EventHandler(this.DeleteDepositToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // UsersList
            // 
            this.UsersList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UsersList.DataSource = this.CustomersBindingSource;
            this.UsersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersList.FormattingEnabled = true;
            this.UsersList.ItemHeight = 16;
            this.UsersList.Location = new System.Drawing.Point(12, 60);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(280, 452);
            this.UsersList.TabIndex = 1;
            this.UsersList.SelectedValueChanged += new System.EventHandler(this.UsersList_SelectedValueChanged);
            // 
            // DepositsList
            // 
            this.DepositsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepositsList.DataSource = this.DepositsBindingSource;
            this.DepositsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepositsList.FormattingEnabled = true;
            this.DepositsList.ItemHeight = 16;
            this.DepositsList.Location = new System.Drawing.Point(298, 60);
            this.DepositsList.Name = "DepositsList";
            this.DepositsList.Size = new System.Drawing.Size(474, 452);
            this.DepositsList.TabIndex = 2;
            // 
            // UsersListLabel
            // 
            this.UsersListLabel.AutoSize = true;
            this.UsersListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersListLabel.Location = new System.Drawing.Point(12, 35);
            this.UsersListLabel.Name = "UsersListLabel";
            this.UsersListLabel.Size = new System.Drawing.Size(71, 16);
            this.UsersListLabel.TabIndex = 3;
            this.UsersListLabel.Text = "Клиенты";
            // 
            // DepositsListLabel
            // 
            this.DepositsListLabel.AutoSize = true;
            this.DepositsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepositsListLabel.Location = new System.Drawing.Point(295, 35);
            this.DepositsListLabel.Name = "DepositsListLabel";
            this.DepositsListLabel.Size = new System.Drawing.Size(81, 16);
            this.DepositsListLabel.TabIndex = 4;
            this.DepositsListLabel.Text = "Депозиты";
            // 
            // UploadAllToolStripMenuItem
            // 
            this.UploadAllToolStripMenuItem.Name = "UploadAllToolStripMenuItem";
            this.UploadAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UploadAllToolStripMenuItem.Text = "Обновить все";
            this.UploadAllToolStripMenuItem.Click += new System.EventHandler(this.UploadAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DepositsListLabel);
            this.Controls.Add(this.UsersListLabel);
            this.Controls.Add(this.DepositsList);
            this.Controls.Add(this.UsersList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainMenuForm";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepositsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ListBox UsersList;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private System.Windows.Forms.ListBox DepositsList;
        private System.Windows.Forms.Label UsersListLabel;
        private System.Windows.Forms.Label DepositsListLabel;
        private System.Windows.Forms.BindingSource DepositsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem депозитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteDepositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UploadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}

