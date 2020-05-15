namespace CustomerApp
{
    partial class RegisterForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.registerButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(13, 52);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(47, 16);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(13, 184);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(48, 16);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Ф.И.О.";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(13, 96);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 16);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(13, 140);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(122, 16);
            this.accountNumberLabel.TabIndex = 3;
            this.accountNumberLabel.Text = "Номер лиц. счета";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 228);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 16);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Адрес";
            // 
            // birthDate
            // 
            this.birthDate.AutoSize = true;
            this.birthDate.Location = new System.Drawing.Point(13, 272);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(107, 16);
            this.birthDate.TabIndex = 5;
            this.birthDate.Text = "Дата рождения";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(165, 52);
            this.loginTextBox.MaxLength = 30;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(230, 22);
            this.loginTextBox.TabIndex = 6;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(69, 184);
            this.fullNameTextBox.MaxLength = 100;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(326, 22);
            this.fullNameTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(165, 96);
            this.passwordTextBox.MaxLength = 30;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(230, 22);
            this.passwordTextBox.TabIndex = 7;
            // 
            // accNumberTextBox
            // 
            this.accNumberTextBox.Location = new System.Drawing.Point(163, 140);
            this.accNumberTextBox.Mask = "000000000";
            this.accNumberTextBox.Name = "accNumberTextBox";
            this.accNumberTextBox.Size = new System.Drawing.Size(70, 22);
            this.accNumberTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(69, 228);
            this.addressTextBox.MaxLength = 170;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(326, 22);
            this.addressTextBox.TabIndex = 10;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(195, 272);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.birthDateTimePicker.TabIndex = 11;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(16, 346);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(174, 34);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Создать аккаунт";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(221, 346);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(174, 34);
            this.returnButton.TabIndex = 13;
            this.returnButton.Text = "Назад";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 392);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.accNumberTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.loginLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 431);
            this.MinimumSize = new System.Drawing.Size(423, 431);
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label birthDate;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.MaskedTextBox accNumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button returnButton;
    }
}