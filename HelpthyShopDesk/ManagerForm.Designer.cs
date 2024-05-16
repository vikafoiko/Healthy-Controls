namespace HelpthyShopDesk
{
    partial class ManagerForm
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
            productTabPage = new TabPage();
            productDataGridView = new DataGridView();
            panel1 = new Panel();
            filterButton = new Button();
            searchButton = new Button();
            updateProductButton = new Button();
            deleteProductButton = new Button();
            createProductButton = new Button();
            searchTextBox = new TextBox();
            productTabIndex = new TabControl();
            productTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            panel1.SuspendLayout();
            productTabIndex.SuspendLayout();
            SuspendLayout();
            // 
            // productTabPage
            // 
            productTabPage.Controls.Add(productDataGridView);
            productTabPage.Controls.Add(panel1);
            productTabPage.Location = new Point(4, 24);
            productTabPage.Name = "productTabPage";
            productTabPage.Padding = new Padding(3);
            productTabPage.Size = new Size(792, 422);
            productTabPage.TabIndex = 0;
            productTabPage.Text = "Товары";
            productTabPage.UseVisualStyleBackColor = true;
            // 
            // productDataGridView
            // 
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Dock = DockStyle.Fill;
            productDataGridView.Location = new Point(3, 64);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.ReadOnly = true;
            productDataGridView.Size = new Size(786, 355);
            productDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(filterButton);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(updateProductButton);
            panel1.Controls.Add(deleteProductButton);
            panel1.Controls.Add(createProductButton);
            panel1.Controls.Add(searchTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 61);
            panel1.TabIndex = 0;
            // 
            // filterButton
            // 
            filterButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterButton.Location = new Point(624, 32);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(159, 23);
            filterButton.TabIndex = 5;
            filterButton.Text = "фильтр";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.Location = new Point(458, 32);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(160, 23);
            searchButton.TabIndex = 4;
            searchButton.Text = "поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // updateProductButton
            // 
            updateProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updateProductButton.Location = new Point(287, 32);
            updateProductButton.Name = "updateProductButton";
            updateProductButton.Size = new Size(165, 23);
            updateProductButton.TabIndex = 3;
            updateProductButton.Text = "Изменить";
            updateProductButton.UseVisualStyleBackColor = true;
            updateProductButton.Click += updateProductButton_Click;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Location = new Point(146, 32);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(135, 23);
            deleteProductButton.TabIndex = 2;
            deleteProductButton.Text = "Удалить";
            deleteProductButton.UseVisualStyleBackColor = true;
            deleteProductButton.Click += deleteProductButton_Click;
            // 
            // createProductButton
            // 
            createProductButton.Location = new Point(5, 32);
            createProductButton.Name = "createProductButton";
            createProductButton.Size = new Size(135, 23);
            createProductButton.TabIndex = 1;
            createProductButton.Text = "Создать продукт";
            createProductButton.UseVisualStyleBackColor = true;
            createProductButton.Click += createProductButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.Location = new Point(5, 3);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(776, 23);
            searchTextBox.TabIndex = 0;
            // 
            // productTabIndex
            // 
            productTabIndex.Controls.Add(productTabPage);
            productTabIndex.Dock = DockStyle.Fill;
            productTabIndex.Location = new Point(0, 0);
            productTabIndex.Name = "productTabIndex";
            productTabIndex.SelectedIndex = 0;
            productTabIndex.Size = new Size(800, 450);
            productTabIndex.TabIndex = 0;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productTabIndex);
            MinimumSize = new Size(816, 489);
            Name = "ManagerForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "ManagerForm Healthy Control";
            productTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            productTabIndex.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage productTabPage;
        private DataGridView productDataGridView;
        private Panel panel1;
        private Button filterButton;
        private Button searchButton;
        private Button updateProductButton;
        private Button deleteProductButton;
        private Button createProductButton;
        private TextBox searchTextBox;
        private TabControl productTabIndex;
    }
}