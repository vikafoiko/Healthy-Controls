namespace HelpthyShopDesk
{
    partial class CreateUserForm
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
            typeCombobox = new ComboBox();
            typeUser = new Label();
            loginTextBox = new TextBox();
            logoginLabel = new Label();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            secondNameLabel = new Label();
            secondNameTextBox = new TextBox();
            codeNumbrercUpDown = new NumericUpDown();
            codeLabel = new Label();
            photoPictureBox = new PictureBox();
            saveButton = new Button();
            cancellationButton = new Button();
            ((System.ComponentModel.ISupportInitialize)codeNumbrercUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)photoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // typeCombobox
            // 
            typeCombobox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            typeCombobox.DisplayMember = "Админ";
            typeCombobox.FormattingEnabled = true;
            typeCombobox.Items.AddRange(new object[] { "Админ", "Менеджер", "Работник" });
            typeCombobox.Location = new Point(121, 12);
            typeCombobox.Name = "typeCombobox";
            typeCombobox.Size = new Size(433, 23);
            typeCombobox.TabIndex = 0;
            typeCombobox.ValueMember = "Работник";
            typeCombobox.SelectedIndexChanged += typeCombobox_SelectedIndexChanged;
            // 
            // typeUser
            // 
            typeUser.AutoSize = true;
            typeUser.Location = new Point(27, 15);
            typeUser.Name = "typeUser";
            typeUser.Size = new Size(88, 15);
            typeUser.TabIndex = 1;
            typeUser.Text = "Тип Работника";
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginTextBox.Location = new Point(121, 41);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(433, 23);
            loginTextBox.TabIndex = 2;
            // 
            // logoginLabel
            // 
            logoginLabel.AutoSize = true;
            logoginLabel.Location = new Point(27, 44);
            logoginLabel.Name = "logoginLabel";
            logoginLabel.Size = new Size(41, 15);
            logoginLabel.TabIndex = 3;
            logoginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(27, 73);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(121, 70);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(433, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(27, 102);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(31, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Имя";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(121, 99);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(433, 23);
            nameTextBox.TabIndex = 6;
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Location = new Point(27, 131);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new Size(58, 15);
            secondNameLabel.TabIndex = 9;
            secondNameLabel.Text = "Фамилия";
            // 
            // secondNameTextBox
            // 
            secondNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            secondNameTextBox.Location = new Point(121, 128);
            secondNameTextBox.Name = "secondNameTextBox";
            secondNameTextBox.Size = new Size(433, 23);
            secondNameTextBox.TabIndex = 8;
            // 
            // codeNumbrercUpDown
            // 
            codeNumbrercUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            codeNumbrercUpDown.Location = new Point(121, 158);
            codeNumbrercUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            codeNumbrercUpDown.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            codeNumbrercUpDown.Name = "codeNumbrercUpDown";
            codeNumbrercUpDown.Size = new Size(433, 23);
            codeNumbrercUpDown.TabIndex = 10;
            codeNumbrercUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            codeNumbrercUpDown.Visible = false;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(27, 160);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(27, 15);
            codeLabel.TabIndex = 11;
            codeLabel.Text = "Код";
            codeLabel.Visible = false;
            // 
            // photoPictureBox
            // 
            photoPictureBox.BackColor = Color.FromArgb(255, 192, 192);
            photoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            photoPictureBox.Location = new Point(27, 187);
            photoPictureBox.Name = "photoPictureBox";
            photoPictureBox.Size = new Size(160, 160);
            photoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            photoPictureBox.TabIndex = 12;
            photoPictureBox.TabStop = false;
            photoPictureBox.Click += photoPictureBox_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(193, 324);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(179, 23);
            saveButton.TabIndex = 13;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancellationButton
            // 
            cancellationButton.Location = new Point(378, 324);
            cancellationButton.Name = "cancellationButton";
            cancellationButton.Size = new Size(176, 23);
            cancellationButton.TabIndex = 14;
            cancellationButton.Text = "Отмена";
            cancellationButton.UseVisualStyleBackColor = true;
            cancellationButton.Click += cancellationButton_Click;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 375);
            Controls.Add(cancellationButton);
            Controls.Add(saveButton);
            Controls.Add(photoPictureBox);
            Controls.Add(codeLabel);
            Controls.Add(codeNumbrercUpDown);
            Controls.Add(secondNameLabel);
            Controls.Add(secondNameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(logoginLabel);
            Controls.Add(loginTextBox);
            Controls.Add(typeUser);
            Controls.Add(typeCombobox);
            Name = "CreateUserForm";
            ShowIcon = false;
            Text = "CreateUserForm Healthy Control";
            ((System.ComponentModel.ISupportInitialize)codeNumbrercUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)photoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox typeCombobox;
        private Label typeUser;
        private TextBox loginTextBox;
        private Label logoginLabel;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label secondNameLabel;
        private TextBox secondNameTextBox;
        private NumericUpDown codeNumbrercUpDown;
        private Label codeLabel;
        private PictureBox photoPictureBox;
        private Button saveButton;
        private Button cancellationButton;
    }
}