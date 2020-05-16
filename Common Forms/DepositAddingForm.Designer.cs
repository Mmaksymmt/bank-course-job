namespace Common_Forms
{
    partial class DepositAddingForm
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
            this.conditionsComboBox = new System.Windows.Forms.ComboBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueUpDown = new System.Windows.Forms.NumericUpDown();
            this.createButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // conditionsComboBox
            // 
            this.conditionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionsComboBox.FormattingEnabled = true;
            this.conditionsComboBox.Location = new System.Drawing.Point(12, 28);
            this.conditionsComboBox.Name = "conditionsComboBox";
            this.conditionsComboBox.Size = new System.Drawing.Size(324, 24);
            this.conditionsComboBox.TabIndex = 0;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(9, 80);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(51, 16);
            this.valueLabel.TabIndex = 1;
            this.valueLabel.Text = "Сумма";
            // 
            // valueUpDown
            // 
            this.valueUpDown.DecimalPlaces = 2;
            this.valueUpDown.Location = new System.Drawing.Point(12, 115);
            this.valueUpDown.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.valueUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueUpDown.Name = "valueUpDown";
            this.valueUpDown.Size = new System.Drawing.Size(324, 22);
            this.valueUpDown.TabIndex = 2;
            this.valueUpDown.ThousandsSeparator = true;
            this.valueUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 210);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(157, 32);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(179, 210);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(157, 32);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Отменить";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // DepositAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 254);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.valueUpDown);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.conditionsComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(364, 293);
            this.MinimumSize = new System.Drawing.Size(364, 293);
            this.Name = "DepositAddingForm";
            this.Text = "Добавление депозита";
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox conditionsComboBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.NumericUpDown valueUpDown;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button returnButton;
    }
}