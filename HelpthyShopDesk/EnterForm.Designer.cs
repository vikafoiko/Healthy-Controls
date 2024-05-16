namespace HelpthyShopDesk
{
    partial class EnterForm
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
            enterButton = new Button();
            loginLabel = new Label();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            codeTextBox = new TextBox();
            codeLabel = new Label();
            SuspendLayout();
            // 
            // enterButton
            // 
            enterButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            enterButton.Location = new Point(36, 162);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(231, 49);
            enterButton.TabIndex = 0;
            enterButton.Text = "Вход";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(12, 9);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(41, 15);
            loginLabel.TabIndex = 1;
            loginLabel.Text = "Логин";
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginTextBox.Location = new Point(12, 27);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(281, 23);
            loginTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(12, 71);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(281, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 53);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(49, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Пароль";
            // 
            // codeTextBox
            // 
            codeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            codeTextBox.Location = new Point(12, 115);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(281, 23);
            codeTextBox.TabIndex = 6;
            codeTextBox.Visible = false;
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(12, 97);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(27, 15);
            codeLabel.TabIndex = 5;
            codeLabel.Text = "Код";
            codeLabel.Visible = false;
            // 
            // EnterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 223);
            Controls.Add(codeTextBox);
            Controls.Add(codeLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(loginTextBox);
            Controls.Add(loginLabel);
            Controls.Add(enterButton);
            MinimumSize = new Size(321, 262);
            Name = "EnterForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterButton;
        private Label loginLabel;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox codeTextBox;
        private Label codeLabel;
    }
}