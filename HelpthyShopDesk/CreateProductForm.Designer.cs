namespace HelpthyShopDesk
{
    partial class CreateProductForm
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
            productPictureBox = new PictureBox();
            nameTextBox = new TextBox();
            companyComboBox = new ComboBox();
            descriptionRichTextBox = new RichTextBox();
            label1 = new Label();
            categoryComboBox = new ComboBox();
            countComboBox = new TextBox();
            costNumberUpDown = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)costNumberUpDown).BeginInit();
            SuspendLayout();
            // 
            // productPictureBox
            // 
            productPictureBox.BackColor = Color.FromArgb(255, 192, 192);
            productPictureBox.Location = new Point(12, 12);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(210, 210);
            productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productPictureBox.TabIndex = 0;
            productPictureBox.TabStop = false;
            productPictureBox.Click += pictureBox1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(338, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(213, 23);
            nameTextBox.TabIndex = 1;
            // 
            // companyComboBox
            // 
            companyComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            companyComboBox.FormattingEnabled = true;
            companyComboBox.Location = new Point(338, 99);
            companyComboBox.Name = "companyComboBox";
            companyComboBox.Size = new Size(213, 23);
            companyComboBox.TabIndex = 2;
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionRichTextBox.Location = new Point(338, 157);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(213, 65);
            descriptionRichTextBox.TabIndex = 3;
            descriptionRichTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Название";
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(338, 70);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(213, 23);
            categoryComboBox.TabIndex = 5;
            // 
            // countComboBox
            // 
            countComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            countComboBox.Location = new Point(338, 41);
            countComboBox.Name = "countComboBox";
            countComboBox.ReadOnly = true;
            countComboBox.Size = new Size(213, 23);
            countComboBox.TabIndex = 6;
            // 
            // costNumberUpDown
            // 
            costNumberUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            costNumberUpDown.DecimalPlaces = 2;
            costNumberUpDown.Location = new Point(338, 128);
            costNumberUpDown.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            costNumberUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            costNumberUpDown.Name = "costNumberUpDown";
            costNumberUpDown.Size = new Size(213, 23);
            costNumberUpDown.TabIndex = 7;
            costNumberUpDown.Value = new decimal(new int[] { 100, 0, 0, 65536 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 44);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 8;
            label2.Text = "Продано";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 73);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Категория";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 102);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "Компания";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 130);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 11;
            label5.Text = "Цена";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 157);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 12;
            label6.Text = "Описание";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 226);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(210, 33);
            saveButton.TabIndex = 13;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cancelButton.Location = new Point(338, 228);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(210, 33);
            cancelButton.TabIndex = 14;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // CreateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 271);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(costNumberUpDown);
            Controls.Add(countComboBox);
            Controls.Add(categoryComboBox);
            Controls.Add(label1);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(companyComboBox);
            Controls.Add(nameTextBox);
            Controls.Add(productPictureBox);
            MinimumSize = new Size(579, 310);
            Name = "CreateProductForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateProductForm Healthy Control";
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)costNumberUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productPictureBox;
        private TextBox nameTextBox;
        private ComboBox companyComboBox;
        private RichTextBox descriptionRichTextBox;
        private Label label1;
        private ComboBox categoryComboBox;
        private TextBox countComboBox;
        private NumericUpDown costNumberUpDown;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button saveButton;
        private Button cancelButton;
    }
}