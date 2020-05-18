namespace AdminApp
{
    partial class ConditionEditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionEditingForm));
            this.percentLabel = new System.Windows.Forms.Label();
            this.percentUpDown = new System.Windows.Forms.NumericUpDown();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalComboBox = new System.Windows.Forms.ComboBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationUpDown = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.percentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(13, 18);
            this.percentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(65, 16);
            this.percentLabel.TabIndex = 0;
            this.percentLabel.Text = "Процент";
            // 
            // percentUpDown
            // 
            this.percentUpDown.Location = new System.Drawing.Point(16, 53);
            this.percentUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percentUpDown.Name = "percentUpDown";
            this.percentUpDown.Size = new System.Drawing.Size(62, 22);
            this.percentUpDown.TabIndex = 1;
            this.percentUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(110, 18);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(73, 16);
            this.intervalLabel.TabIndex = 2;
            this.intervalLabel.Text = "Интервал";
            // 
            // intervalComboBox
            // 
            this.intervalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalComboBox.FormattingEnabled = true;
            this.intervalComboBox.Location = new System.Drawing.Point(113, 53);
            this.intervalComboBox.Name = "intervalComboBox";
            this.intervalComboBox.Size = new System.Drawing.Size(70, 24);
            this.intervalComboBox.TabIndex = 3;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(218, 18);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(70, 16);
            this.durationLabel.TabIndex = 4;
            this.durationLabel.Text = "Продолж.";
            // 
            // durationUpDown
            // 
            this.durationUpDown.Location = new System.Drawing.Point(221, 53);
            this.durationUpDown.Name = "durationUpDown";
            this.durationUpDown.Size = new System.Drawing.Size(67, 22);
            this.durationUpDown.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(166, 120);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 27);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 120);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 27);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ConditionEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 159);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.durationUpDown);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.intervalComboBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.percentUpDown);
            this.Controls.Add(this.percentLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConditionEditingForm";
            this.Text = "Редактировать";
            ((System.ComponentModel.ISupportInitialize)(this.percentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.NumericUpDown percentUpDown;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.ComboBox intervalComboBox;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.NumericUpDown durationUpDown;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}