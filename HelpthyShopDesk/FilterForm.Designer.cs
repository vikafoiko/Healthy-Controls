namespace HelpthyShopDesk
{
    partial class FilterForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            categoryDataGridView = new DataGridView();
            CompanyDataGridView = new DataGridView();
            panel1 = new Panel();
            cancelButton = new Button();
            confirmButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompanyDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(categoryDataGridView, 0, 0);
            tableLayoutPanel1.Controls.Add(CompanyDataGridView, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(395, 351);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // categoryDataGridView
            // 
            categoryDataGridView.AllowUserToAddRows = false;
            categoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoryDataGridView.Dock = DockStyle.Fill;
            categoryDataGridView.Location = new Point(3, 3);
            categoryDataGridView.Name = "categoryDataGridView";
            categoryDataGridView.Size = new Size(191, 345);
            categoryDataGridView.TabIndex = 0;
            // 
            // CompanyDataGridView
            // 
            CompanyDataGridView.AllowUserToAddRows = false;
            CompanyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompanyDataGridView.Dock = DockStyle.Fill;
            CompanyDataGridView.Location = new Point(200, 3);
            CompanyDataGridView.Name = "CompanyDataGridView";
            CompanyDataGridView.Size = new Size(192, 345);
            CompanyDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(confirmButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 351);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 86);
            panel1.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(200, 6);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(182, 68);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(12, 6);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(182, 68);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "применть";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 437);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "FilterForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Фильтр";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompanyDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView categoryDataGridView;
        private DataGridView CompanyDataGridView;
        private Panel panel1;
        private Button cancelButton;
        private Button confirmButton;
    }
}