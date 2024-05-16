namespace HelpthyShopDesk
{
    partial class BuyForm
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
            cancelButton = new Button();
            buyButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            costNumberUpDown = new NumericUpDown();
            categoryComboBox = new ComboBox();
            label1 = new Label();
            descriptionRichTextBox = new RichTextBox();
            companyComboBox = new ComboBox();
            nameTextBox = new TextBox();
            productPictureBox = new PictureBox();
            countNumbericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)costNumberUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countNumbericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cancelButton.Location = new Point(338, 228);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(178, 33);
            cancelButton.TabIndex = 29;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // buyButton
            // 
            buyButton.Location = new Point(12, 226);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(210, 33);
            buyButton.TabIndex = 28;
            buyButton.Text = "Добавить";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 157);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 27;
            label6.Text = "Описание";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 130);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 26;
            label5.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 102);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 25;
            label4.Text = "Компания";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 73);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 24;
            label3.Text = "Категория";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 44);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 23;
            label2.Text = "Продано";
            // 
            // costNumberUpDown
            // 
            costNumberUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            costNumberUpDown.DecimalPlaces = 2;
            costNumberUpDown.Location = new Point(338, 128);
            costNumberUpDown.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            costNumberUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            costNumberUpDown.Name = "costNumberUpDown";
            costNumberUpDown.Size = new Size(181, 23);
            costNumberUpDown.TabIndex = 22;
            costNumberUpDown.Value = new decimal(new int[] { 100, 0, 0, 65536 });
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(338, 70);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(181, 23);
            categoryComboBox.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 19;
            label1.Text = "Название";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionRichTextBox.Location = new Point(338, 157);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(181, 65);
            descriptionRichTextBox.TabIndex = 18;
            descriptionRichTextBox.Text = "";
            // 
            // companyComboBox
            // 
            companyComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            companyComboBox.FormattingEnabled = true;
            companyComboBox.Location = new Point(338, 99);
            companyComboBox.Name = "companyComboBox";
            companyComboBox.Size = new Size(181, 23);
            companyComboBox.TabIndex = 17;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(338, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(181, 23);
            nameTextBox.TabIndex = 16;
            // 
            // productPictureBox
            // 
            productPictureBox.BackColor = Color.FromArgb(255, 192, 192);
            productPictureBox.Location = new Point(12, 12);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(210, 210);
            productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productPictureBox.TabIndex = 15;
            productPictureBox.TabStop = false;
            // 
            // countNumbericUpDown
            // 
            countNumbericUpDown.Location = new Point(338, 41);
            countNumbericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            countNumbericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            countNumbericUpDown.Name = "countNumbericUpDown";
            countNumbericUpDown.Size = new Size(181, 23);
            countNumbericUpDown.TabIndex = 30;
            countNumbericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BuyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 273);
            Controls.Add(countNumbericUpDown);
            Controls.Add(cancelButton);
            Controls.Add(buyButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(costNumberUpDown);
            Controls.Add(categoryComboBox);
            Controls.Add(label1);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(companyComboBox);
            Controls.Add(nameTextBox);
            Controls.Add(productPictureBox);
            Name = "BuyForm";
            ShowIcon = false;
            Text = "BuyForm";
            ((System.ComponentModel.ISupportInitialize)costNumberUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)countNumbericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button buyButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown costNumberUpDown;
        private ComboBox categoryComboBox;
        private Label label1;
        private RichTextBox descriptionRichTextBox;
        private ComboBox companyComboBox;
        private TextBox nameTextBox;
        private PictureBox productPictureBox;
        private NumericUpDown countNumbericUpDown;
    }
}