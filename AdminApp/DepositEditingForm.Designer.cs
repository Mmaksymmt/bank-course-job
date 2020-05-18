namespace AdminApp
{
    partial class DepositEditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositEditingForm));
            this.depositIconBox = new System.Windows.Forms.PictureBox();
            this.percentLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.percentUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.valueUpDown = new System.Windows.Forms.NumericUpDown();
            this.finishDateLabel = new System.Windows.Forms.Label();
            this.finishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.finishTimeHoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.finishTimeMinutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.dotsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depositIconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishTimeHoursUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishTimeMinutesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // depositIconBox
            // 
            this.depositIconBox.Image = global::AdminApp.Properties.Resources.deposit_icon;
            this.depositIconBox.Location = new System.Drawing.Point(10, 52);
            this.depositIconBox.Margin = new System.Windows.Forms.Padding(4);
            this.depositIconBox.Name = "depositIconBox";
            this.depositIconBox.Size = new System.Drawing.Size(100, 100);
            this.depositIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.depositIconBox.TabIndex = 0;
            this.depositIconBox.TabStop = false;
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(117, 52);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(68, 16);
            this.percentLabel.TabIndex = 1;
            this.percentLabel.Text = "Процент:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(117, 91);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(54, 16);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "Сумма:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 16);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Ф.И.О:";
            // 
            // percentUpDown
            // 
            this.percentUpDown.Location = new System.Drawing.Point(191, 52);
            this.percentUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percentUpDown.Name = "percentUpDown";
            this.percentUpDown.Size = new System.Drawing.Size(95, 22);
            this.percentUpDown.TabIndex = 4;
            this.percentUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percentUpDown.ValueChanged += new System.EventHandler(this.InputsValueChanged);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(51, 259);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 40);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(252, 259);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 40);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Назад";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // valueUpDown
            // 
            this.valueUpDown.DecimalPlaces = 2;
            this.valueUpDown.Location = new System.Drawing.Point(120, 121);
            this.valueUpDown.Maximum = new decimal(new int[] {
            -1304428544,
            434162106,
            542,
            0});
            this.valueUpDown.Name = "valueUpDown";
            this.valueUpDown.Size = new System.Drawing.Size(302, 22);
            this.valueUpDown.TabIndex = 8;
            this.valueUpDown.ThousandsSeparator = true;
            this.valueUpDown.ValueChanged += new System.EventHandler(this.InputsValueChanged);
            // 
            // finishDateLabel
            // 
            this.finishDateLabel.AutoSize = true;
            this.finishDateLabel.Location = new System.Drawing.Point(117, 164);
            this.finishDateLabel.Name = "finishDateLabel";
            this.finishDateLabel.Size = new System.Drawing.Size(84, 16);
            this.finishDateLabel.TabIndex = 9;
            this.finishDateLabel.Text = "Окончание:";
            // 
            // finishDatePicker
            // 
            this.finishDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finishDatePicker.Location = new System.Drawing.Point(222, 164);
            this.finishDatePicker.Name = "finishDatePicker";
            this.finishDatePicker.Size = new System.Drawing.Size(200, 22);
            this.finishDatePicker.TabIndex = 10;
            this.finishDatePicker.ValueChanged += new System.EventHandler(this.InputsValueChanged);
            // 
            // finishTimeHoursUpDown
            // 
            this.finishTimeHoursUpDown.Location = new System.Drawing.Point(222, 202);
            this.finishTimeHoursUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.finishTimeHoursUpDown.Name = "finishTimeHoursUpDown";
            this.finishTimeHoursUpDown.Size = new System.Drawing.Size(39, 22);
            this.finishTimeHoursUpDown.TabIndex = 11;
            this.finishTimeHoursUpDown.ValueChanged += new System.EventHandler(this.InputsValueChanged);
            // 
            // finishTimeMinutesUpDown
            // 
            this.finishTimeMinutesUpDown.Location = new System.Drawing.Point(284, 202);
            this.finishTimeMinutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.finishTimeMinutesUpDown.Name = "finishTimeMinutesUpDown";
            this.finishTimeMinutesUpDown.Size = new System.Drawing.Size(40, 22);
            this.finishTimeMinutesUpDown.TabIndex = 12;
            this.finishTimeMinutesUpDown.ValueChanged += new System.EventHandler(this.InputsValueChanged);
            // 
            // dotsLabel
            // 
            this.dotsLabel.AutoSize = true;
            this.dotsLabel.Location = new System.Drawing.Point(267, 204);
            this.dotsLabel.Name = "dotsLabel";
            this.dotsLabel.Size = new System.Drawing.Size(11, 16);
            this.dotsLabel.TabIndex = 13;
            this.dotsLabel.Text = ":";
            // 
            // DepositEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.dotsLabel);
            this.Controls.Add(this.finishTimeMinutesUpDown);
            this.Controls.Add(this.finishTimeHoursUpDown);
            this.Controls.Add(this.finishDatePicker);
            this.Controls.Add(this.finishDateLabel);
            this.Controls.Add(this.valueUpDown);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.percentUpDown);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.depositIconBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "DepositEditingForm";
            this.Text = "Редактирование депозита";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DepositEditingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.depositIconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishTimeHoursUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishTimeMinutesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox depositIconBox;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.NumericUpDown percentUpDown;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.NumericUpDown valueUpDown;
        private System.Windows.Forms.Label finishDateLabel;
        private System.Windows.Forms.DateTimePicker finishDatePicker;
        private System.Windows.Forms.NumericUpDown finishTimeHoursUpDown;
        private System.Windows.Forms.NumericUpDown finishTimeMinutesUpDown;
        private System.Windows.Forms.Label dotsLabel;
    }
}