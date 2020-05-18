namespace AdminApp
{
    partial class DepositConditionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositConditionsForm));
            this.conditionsGridView = new System.Windows.Forms.DataGridView();
            this.percentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accrualsIntervalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // conditionsGridView
            // 
            this.conditionsGridView.AllowUserToDeleteRows = false;
            this.conditionsGridView.AutoGenerateColumns = false;
            this.conditionsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.conditionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.conditionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.percentColumn,
            this.accrualsIntervalColumn,
            this.durationColumn});
            this.conditionsGridView.DataSource = this.conditionsBindingSource;
            this.conditionsGridView.Location = new System.Drawing.Point(13, 13);
            this.conditionsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.conditionsGridView.MultiSelect = false;
            this.conditionsGridView.Name = "conditionsGridView";
            this.conditionsGridView.ReadOnly = true;
            this.conditionsGridView.RowHeadersVisible = false;
            this.conditionsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.conditionsGridView.Size = new System.Drawing.Size(308, 325);
            this.conditionsGridView.TabIndex = 0;
            this.conditionsGridView.SelectionChanged += new System.EventHandler(this.ConditionsGridView_SelectionChanged);
            // 
            // percentColumn
            // 
            this.percentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.percentColumn.DataPropertyName = "Percent";
            this.percentColumn.HeaderText = "Процент";
            this.percentColumn.Name = "percentColumn";
            this.percentColumn.ReadOnly = true;
            // 
            // accrualsIntervalColumn
            // 
            this.accrualsIntervalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accrualsIntervalColumn.DataPropertyName = "Interval";
            this.accrualsIntervalColumn.HeaderText = "Интервал начислений";
            this.accrualsIntervalColumn.Name = "accrualsIntervalColumn";
            this.accrualsIntervalColumn.ReadOnly = true;
            this.accrualsIntervalColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // durationColumn
            // 
            this.durationColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.durationColumn.DataPropertyName = "Duration";
            this.durationColumn.HeaderText = "Продолж.";
            this.durationColumn.Name = "durationColumn";
            this.durationColumn.ReadOnly = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(235, 345);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 31);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 345);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 31);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(124, 345);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(85, 31);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Измен.";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DepositConditionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 388);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.conditionsGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 427);
            this.MinimumSize = new System.Drawing.Size(350, 427);
            this.Name = "DepositConditionsForm";
            this.Text = "Доступные депозиты";
            ((System.ComponentModel.ISupportInitialize)(this.conditionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView conditionsGridView;
        private System.Windows.Forms.BindingSource conditionsBindingSource;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accrualsIntervalColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationColumn;
        private System.Windows.Forms.Button editButton;
    }
}